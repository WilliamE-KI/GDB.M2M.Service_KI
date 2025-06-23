using System.IO;

/*
HANDLAR OM FILER ISTÄLLET FÖR MAPPAR.
DEN SKAPAR ETT GRÄNSSNITT (IFileInfo) OCH EN KLASS (CustomFileInfo) SOM ANVÄNDS FÖR ATT:
    . REPRESENTERA EN FIL
    . HÄMTA MAPPEN (KATALOGEN) DÄR FILEN LIGGER
*/


namespace GDB.M2M.Service
{
    public interface IFileInfo
    {
        IDirectoryInfo Directory();
    }

    public class CustomFileInfo : IFileInfo
    {
        private readonly FileInfo fileInfo;

        public CustomFileInfo(string path)
        {
            fileInfo = new FileInfo(path);
        }

        public IDirectoryInfo Directory()
        {
            return new CustomDirectoryInfo(fileInfo.Directory);
        }
    }
}
