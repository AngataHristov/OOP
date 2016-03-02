
namespace Blobs.Interfaces
{
    using System.Collections.Generic;

    using Models.Interfaces;

    public interface IDataBase
    {
        IEnumerable<IBlob> AllBlobs { get; }

        void AddBlob(IBlob blob);
    }
}
