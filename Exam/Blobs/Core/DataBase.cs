
namespace Blobs.Core
{
    using System.Collections.Generic;
    using Interfaces;
    using Models.Interfaces;

    public class DataBase : IDataBase
    {
        private readonly IList<IBlob> allBlobs;

        public DataBase()
        {
            this.allBlobs = new List<IBlob>();
        }

        public IEnumerable<IBlob> AllBlobs
        {
            get { return this.allBlobs; }
        }

        public void AddBlob(IBlob blob)
        {
            this.allBlobs.Add(blob);
        }
    }
}
