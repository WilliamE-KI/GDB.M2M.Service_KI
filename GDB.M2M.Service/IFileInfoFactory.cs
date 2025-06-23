/*
HANDLAR OM ATT SKAPA OBJEKT SOM REPRESENTERAR FILER - MEN PÅ ETT KONTROLLERAT OCH 
TESTBART SÄTT. DET ÄR EN DEL AV ETT DESIGNMÖNSTER SOM KALLAS FACTORY PATTERN (FABRIKMÖNSTER)
*/

namespace GDB.M2M.Service
{
    //DET HÄR ÄR ETT GÄRNSSNITT SOM SÄGER: 
    //ALLA KLASSER SOM IMPLEMENTERAR DET MÅSTE HA EN METOD Create(string filePath)
    //SOM RETURNERAR ETT IFileInfo-OBJEKT
    public interface IFileInfoFactory
    {
        IFileInfo Create(string filePath);
    }

    public class FileInfoFactory : IFileInfoFactory
    {
        public IFileInfo Create(string filePath)
        {
            return new CustomFileInfo(filePath);
        }
    }
}