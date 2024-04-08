using Invoice.Logic;


namespace INV_Test
{
    public class INV_Tests
    {
    public void Check_IfLineContainsTheSameEANNumber_ErrorIsThrown()
      {
         var importer = new LineImporter();
         string[] lines = [
            "IL,3548769012345,2.5",
            "IL,3548769012345,2.5"

            ];
         Assert.Throws<InvoiceLineImportException>(() => importer.Importer(lines));
      }
    }
}