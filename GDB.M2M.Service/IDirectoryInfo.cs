using System.IO;

/*
LÄSA INFORMATION OM MAPPAR (KATALOGER) I FILSYSTEMET
MEN PÅ ETT SÄTT SOM GÖR DET ENKLARE ATT TESTA OCH KONTROLLERA I ETT STÖRRE SYSTEM

SYFTET:
ISTÄLLET FÖR ATT ANVÄNDA .NET INBYGGDA DirectoryInfo DIREKT, SKAPAR MAN ETT GRÄNSSNITT
(IDirectoryInfo) OCH EN WRAPPER-KLASS (CustomDirectory) SOM "GÖMMER" DEN RIKTIGA DirectoryInfo

Genom att använda IDirectoryInfo kan man:

Simulera mappar i tester
Byta ut hur man läser mappar utan att ändra resten av koden
*/

namespace GDB.M2M.Service
{
    public interface IDirectoryInfo
    {
        IDirectoryInfo Parent();
        string Name { get; }
    }

    public class CustomDirectoryInfo : IDirectoryInfo
    {
        private readonly DirectoryInfo directoryInfo;

        public CustomDirectoryInfo(DirectoryInfo directoryInfo)
        {
            this.directoryInfo = directoryInfo;
        }

        public string Name
        {
            get { return directoryInfo.Name; }
        }

        public IDirectoryInfo Parent()
        {
            return new CustomDirectoryInfo(directoryInfo.Parent);
        }
    }
}
