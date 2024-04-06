using Invoice.Logic;

namespace LinesImporter_Test
{

   public class LinesImporter_Test
   {
      [Fact]
      public void Check_IfLineIsEmpty_ErrorIsThrown()
      {
         var importer = new LineImporter();
         var line = " ";
         Assert.Throws<InvoiceLineImportException>(() => importer.Import(line));
         
      }
   
      [Fact]
      public void Check_IfLineContainsInvalidData_ErrorIsThrown()
      {
         var importer = new LineImporter();
         var line = "IL,abc";
         Assert.Throws<InvoiceLineImportException>(() => importer.Import(line));
         
      }
   }  
}





