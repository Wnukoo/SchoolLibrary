using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace LibraryCore
{
    public class Library
    {
        private readonly List<BookCopy> _copies = new();
        public IEnumerable<BookCopy> Copies => _copies;

        public BookCopy AddNewCopy(string title, string author, string isbn)
        {
            var copy = new BookCopy(title, author, isbn);
            _copies.Add(copy);
            return copy;
        }

        public bool RemoveCopy(string copyId) => _copies.RemoveAll(c => c.CopyId == copyId) > 0;
        public BookCopy? FindCopy(string copyId) => _copies.FirstOrDefault(c => c.CopyId == copyId);

        public void Borrow(string copyId, LibraryCard card) => (FindCopy(copyId) ?? throw new ArgumentException("Nie znaleziono kopii.")).Borrow(card);
        public void Return(string copyId) => (FindCopy(copyId) ?? throw new ArgumentException("Nie znaleziono kopii.")).Return();

        // ======= Persistence =======
        private static readonly JsonSerializerOptions _jsonOptions = new() { WriteIndented = true };

        public void Save(string path) => File.WriteAllText(path, JsonSerializer.Serialize(_copies, _jsonOptions));

        public void Load(string path)
        {
            if (!File.Exists(path)) return;
            var loaded = JsonSerializer.Deserialize<List<BookCopy>>(File.ReadAllText(path));
            if (loaded is null) return;
            _copies.Clear();
            _copies.AddRange(loaded);
        }
    }
}