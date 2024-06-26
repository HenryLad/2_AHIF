using System.Globalization;

namespace Invoice.Logic;

public abstract class Line { }

public class InvoiceLine(string ean, decimal quantity) : Line
{
    public string EAN { get; } = ean;
    public decimal Quantity { get; } = quantity;
}

public class DiscountLine(decimal percentage) : Line
{
    public decimal Percentage { get; } = percentage;
}

public class LineImporter
{
    /// <summary>
    /// Imports an invoice line or a discount line from the given string.
    /// </summary>
    /// <param name="line">Line of text read from a file that should be imported</param>
    /// <returns>
    /// Line of an invoice or a discount
    /// </returns>
    /// <exception cref="InvoiceLineImportException">Thrown when the import fails</exception>
    /// <remarks>
    /// The import can fail unter the following conditions:
    /// - <paramref name="line"/> is empty
    /// - A line contains invalid data (missing column, empty column, wrong data type, negative values)
    /// In all cases, the exception message should contain a meaningful error message.
    /// </remarks>
    public Line Import(string line)
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            throw new InvoiceLineImportException("Line is empty");
        }

        var parts = line.Split(',');

        if (parts.Length < 2)
        {
            throw new InvoiceLineImportException("Line is missing data");
        }

        if (parts[0] == "IL")
        {
            if (parts.Length != 3)
            {
                throw new InvoiceLineImportException("Invoice line is missing data");
            }

            if (!decimal.TryParse(parts[2], CultureInfo.InvariantCulture, out var quantity) || quantity < 0)
            {
                throw new InvoiceLineImportException("Quantity is not a number");
            }

            return new InvoiceLine(parts[1], quantity);
        }
        else if (parts[0] == "D")
        {
            if (parts.Length != 2)
            {
                throw new InvoiceLineImportException("Discount line is missing data");
            }

            if (!decimal.TryParse(parts[1], CultureInfo.InvariantCulture, out var percentage) || percentage < 0)
            {
                throw new InvoiceLineImportException("Percentage is not a number");
            }

            return new DiscountLine(percentage);
        }
        else
        {
            throw new InvoiceLineImportException("Unknown line type");
        }
    }


    /// <summary>
    /// Imports an invoice and discount lines from the given string array.
    /// </summary>
    /// <param name="lines">Lines read from a file that should be imported</param>
    /// <returns>
    /// Collection of lines and discounts
    /// </returns>
    /// <exception cref="InvoiceLineImportException">Thrown when the import fails</exception>
    /// <remarks>
    /// The import can fail unter the following conditions:
    /// - <paramref name="lines"/> is empty
    /// - A line contains invalid data (missing column, empty column, wrong data type, negative values)
    /// - The same EAN appears multiple times in the lines
    /// In all cases, the exception message should contain a meaningful error message.
    /// </remarks>
    ////// 
    /// 

    public IEnumerable<Line> Importer(string[] lines)
    {
        List<Line> line = [];
        
        HashSet<string> eanSet = new HashSet<string>();
        if (lines.Length == 0) { throw new InvoiceLineImportException("There are no lines to be compiled"); }
        for (int j = 0; j < lines.Length; j++)
        {
            string[] columns = lines[j].Split(',');
            var result = Import(lines[j]);
            if (columns.Length < 2 || columns.Length > 3) { throw new InvoiceLineImportException("There are not engouh/to much arguments in there."); }
            if(!eanSet.Add(columns[1])) throw new InvoiceLineImportException("The same EAN is not allowed to accour twice");

            line.Add(result); 
        }

        return line;



    }
}

public class InvoiceLineImportException : Exception
{
    public InvoiceLineImportException() { }

    public InvoiceLineImportException(string message) : base(message) { }

    public InvoiceLineImportException(string message, Exception innerException) : base(message, innerException) { }
}

