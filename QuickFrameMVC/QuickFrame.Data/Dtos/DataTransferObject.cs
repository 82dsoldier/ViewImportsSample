using ExpressMapper;
using QuickFrame.Data.Interfaces.Dtos;

namespace QuickFrame.Data.Dtos {

	public class DataTransferObject<TSrc, TDest> : IDataTransferObject<TSrc, TDest> {

		public virtual void Register() {
			Mapper.Register<TSrc, TDest>();
			Mapper.Register<TDest, TSrc>();
		}
	}
}