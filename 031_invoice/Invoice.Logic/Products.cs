using System.Globalization;

namespace Invoice.Logic;

public enum UnitOfMeasure
{
    Pieces,
    Kilograms,
}

public enum VATPercentage
{
    Reduced = 10,
    Standard = 20,
}

public record Product(
    string EAN,
    string Name,
    VATPercentage VATPercentage,
    decimal NetPrice,
    UnitOfMeasure UnitOfMeasure,
    bool IsMultipack
);

public class ProductImporter
{
    /// <summary>
    /// Imports products from the given lines.
    /// </summary>
    /// <param name="lines">Lines read from a file that should be imported</param>
    /// <returns>
    /// Collection of products
    /// </returns>
    /// <exception cref="ProductImportException">Thrown when the import fails</exception>
    /// <remarks>
    /// The import can fail unter the following conditions:
    /// - <paramref name="lines"/> is empty
    /// - The header line is missing or contains invalid column names or the order of columns is wrong
    /// - A line contains invalid data (missing column, empty column, wrong data type, negative values)
    /// - IsMultiPack is true when unit of measure is not Pieces
    /// In all cases, the exception message should contain a meaningful error message.
    /// </remarks>
public IEnumerable<Product> Import(string[] lines)
{
    string hl = "EAN,Name,VATPercentage,NetPrice,UnitOfMeasure,IsMultiPack\r";
    if(lines.Length == 0) {throw new ProductImportException("The File is Empty");}
    if(lines[0] != hl) {throw new ProductImportException("The Headerline is invalid");}

    List<Product> products = new List<Product>();

    for(int i = 1; i < lines.Length; i++)
    {
        string[] columns = lines[i].Split(',');

        if(columns.Length != 6) throw new ProductImportException("Invalid line format");
        if (columns[4] != "pcs" && columns[4] != "kg") { throw new ProductImportException("The Unit of Messagerment ist not correct"); }
        if (columns[2] != "10" && columns[2] != "20") { throw new ProductImportException("invalid Percantage of VAT Percent please use 10 & 20 "); }
        if (decimal.Parse(columns[3]) < 0) { throw new ProductImportException("The Price shloud not be neagtive"); }
        if(!decimal.TryParse(columns[3], CultureInfo.InvariantCulture, out var Price)){throw new ProductImportException("The Net Price should not contain anything other than Digits");}

        var VATP = VATPercentage.Standard;
        var UOM = UnitOfMeasure.Kilograms;
        if (columns[2] == "10") { VATP = VATPercentage.Reduced; }
        if (columns[4] == "pcs") { UOM = UnitOfMeasure.Pieces; }

        var product = new Product(
            columns[0],
            columns[1],
            VATP,
            Price,
            UOM,
            bool.Parse(columns[5])
        );

        products.Add(product);
    }

    return products;
}
}

public class ProductImportException : Exception
{
    public ProductImportException() { }

    public ProductImportException(string message) : base(message) { }

    public ProductImportException(string message, Exception innerException) : base(message, innerException) { }
}
