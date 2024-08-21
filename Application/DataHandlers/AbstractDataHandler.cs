using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DataHandlers
{
    public abstract class AbstractDataHandler<TRepository>
    {
        internal abstract TRepository Read();
        internal abstract void Write(TRepository repository);

        protected void CheckIfFileExists(string fullPath)
        {
            string directory = Path.GetDirectoryName(fullPath);

            // Tjek og opret mappen hvis den ikke findes
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            if (!File.Exists(fullPath))
            {
                FileStream fs = File.Create(fullPath);
                fs.Close();
            }
        }
    }
}
