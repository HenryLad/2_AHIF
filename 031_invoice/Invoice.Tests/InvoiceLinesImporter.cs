using Invoice.Logic;

namespace LinesImporter_Test
{

   public class LinesImporter_Test
   {
      [Fact]
      public void Check_IfLineIsEmpty_ErrorIsThrown()
      {
         var importer = new LineImporter();
         string[] lines = [];
         Assert.Throws<InvoiceLineImportException>(() => importer.Importer(lines));

      }

      [Fact]
      public void Check_IfLineContainsInvalidData_ErrorIsThrown()
      {
         var importer = new LineImporter();
         string[] lines = ["IL,a!b,fortnie,2234,34"];
         Assert.Throws<InvoiceLineImportException>(() => importer.Importer(lines));

      }
      [Fact]
      public void Check_IfLineContainsTheSameEANNumber_ErrorIsThrown()
      {
         var importer = new LineImporter();
         string[] lines = [
            "IL,3548769012345,2.5",
            "IL,3548769012345,2.5"

            ];
         Assert.Throws<InvoiceLineImportException>(() => importer.Importer(lines));
      }
      [Fact]
      public void Import_ValidLines_ReturnsCorrectLines()
      {
         // Arrange
         var importer = new LineImporter();
         string[] lines = {
        "IL,3548769012345,2.5",
        "IL,8912345670123,3",
        "D,5",
        "IL,5678932104987,4",
        "IL,8790234561876,1",
        "IL,1234012345678,6"
    };

         // Act
         var result = importer.Importer(lines);

         // Assert
         Assert.Equal(6, result.Count());
         // Add more assertions here to check the content of the returned lines
      }
      // Use hashset to check if the EAN is contained twice.


   }
}





