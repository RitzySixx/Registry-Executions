using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CachedProgramsList.Register
{
    class Entry
    {
        private string path, name;
        private bool valid = false, exists = false;
        private DateTime creation, modification;
        public string Path { get => path; }
        public bool Valid { get => valid; }
        public bool Exists { get => exists; }
        public DateTime Creation { get => creation; }
        public DateTime Modification { get => modification; }
        public string Name { get => name; }

        public Entry(string path)
        {
            if (path == null)
            {
                this.path = string.Empty;
                return;
            }

            this.path = path;
            checkIfValid();
            if (valid)
            {
                checkIfExists();
                if (exists)
                {
                    try
                    {
                        creation = File.GetCreationTime(this.path);
                        modification = File.GetLastWriteTime(this.path);
                    }
                    catch (Exception)
                    {
                        // If we can't get file times, use current time
                        creation = DateTime.Now;
                        modification = DateTime.Now;
                    }
                }
            }
        }

        //https://www.oreilly.com/library/view/regular-expressions-cookbook/9781449327453/ch08s18.html
        string validPathRegex = @"[a-zA-Z]:\\(?:[^\\\/:*?" + "\"" + @"<>|\r\n]+\\)*([^\\\/:*?" + "\"" + @"<>|\r\n]*)";

        private void checkIfValid()
        {
            try
            {
                if (path.EndsWith(".ApplicationCompany") || path.EndsWith(".FriendlyAppName"))
                {
                    path = path.Replace(".FriendlyAppName", "").Replace(".ApplicationCompany", "");
                }

                // Check if it's already a valid path
                if (path.Contains(":\\") && (path.EndsWith(".exe") || path.EndsWith(".msi") ||
                    path.EndsWith(".bat") || path.EndsWith(".cmd") || path.EndsWith(".com")))
                {
                    valid = true;
                    name = System.IO.Path.GetFileNameWithoutExtension(path);
                    return;
                }

                Regex rg = new Regex(validPathRegex);
                MatchCollection pathValid = rg.Matches(path);
                if (pathValid.Count > 0)
                {
                    valid = true;
                    name = pathValid[0].Groups[1].Value;
                    if (string.IsNullOrEmpty(name))
                    {
                        name = System.IO.Path.GetFileNameWithoutExtension(path);
                    }
                }
            }
            catch (Exception)
            {
                valid = false;
                name = System.IO.Path.GetFileNameWithoutExtension(path);
                if (string.IsNullOrEmpty(name))
                {
                    name = path;
                }
            }
        }

        private void checkIfExists()
        {
            try
            {
                if (File.Exists(path))
                {
                    exists = true;
                }
            }
            catch (Exception)
            {
                exists = false;
            }
        }
    }
}