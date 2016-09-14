namespace QuickFrame.Data.Models {

	public class DataModelCore<TDataType> {
		public TDataType Id { get; set; }
		public bool IsDeleted { get; set; }
	}

	public class DataModelInt : DataModelCore<int> {
	}

	public class DataModel : DataModelInt {
	}
}