using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.DataHandlers
{
    public abstract class AbstractDataHandler<TRepository>
    {
        private readonly string Alphabeat = "ABCDEFGHIJKLMNOPQRSTUVWXYZÆØÅ";
        private readonly string Key = "NQXPOMAFTRHLZGECYJIUWSKDVBÆØÅ";

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
        protected string EncryptString(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (Char.IsUpper(c))
                {
                    int IndexInAlphabeat = Alphabeat.IndexOf(c);
                    sb.Append(Key[IndexInAlphabeat]);
                }
                else if (Char.IsLower(c))
                {
                    int IndexInAlphabeat = Alphabeat.IndexOf(Char.ToUpper(c));
                    sb.Append(Char.ToLower((Key[IndexInAlphabeat])));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
        protected string DecryptString(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (Char.IsUpper(c))
                {
                    int IndexInKey = Key.IndexOf(c);
                    sb.Append(Alphabeat[IndexInKey]);
                }
                else if (Char.IsLower(c))
                {
                    int IndexInKey = Key.IndexOf(Char.ToUpper(c));
                    sb.Append(Char.ToLower((Alphabeat[IndexInKey])));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

    }
}
