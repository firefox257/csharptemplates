namespace MessageCenter
{
	public class MsgcBase<T>
	{
		protected static Dictionary<object, Action<T>> alist = new Dictionary<object, Action<T>>();
		public static void Subscribe(object o, Action<T> a)
		{
			alist[o] = a;
		}


		public static async Task<T> Send(T a)
		{
			foreach (var i in alist)
			{
				await Task.Factory.StartNew(() =>
				{
					i.Value(a);
				});
			}
			return a;
		}
		public static void Unsubscribe(object o, Action<T> a)
		{
			alist.Remove(o);
		}
	}

	public class Msgc
	{
		static private string FuncName 
		{ get
			{
				return "Message";
			} 
		}
		public static async Task<T> Send<T>(T a)
		{
			return await MsgcBase<T>.Send(a);
		}

		public static void SubscribeClass(object o)
		{
			Type c = o.GetType();
			var m = c.GetMethods();
			foreach (var i in m)
			{
				if (!i.IsStatic && i.Name == FuncName)
				{
					var tt = i.GetParameters()[0].ParameterType;
					//var tt = mm[0].ParameterType;
					//Console.WriteLine("i.IsStatic " + i.IsStatic);

					var subscribe = typeof(MsgcBase<>).MakeGenericType(new[] { tt }).GetMethod("Subscribe");
					var delegateType = typeof(Action<>).MakeGenericType(tt);
					var del = Delegate.CreateDelegate(delegateType, null, i);
					//It will never be null since it is getting from MsgcBase.
					subscribe.Invoke(null, new[] { o, del });



				}
			}
		}

		public static void SubscribeStatics(Type c)
		{
			object o = c;
			//Type c = o.GetType();
			var m = c.GetMethods();
			foreach (var i in m)
			{
				if (i.IsStatic && i.Name == FuncName)
				{
					var tt = i.GetParameters()[0].ParameterType;
					//var tt = mm[0].ParameterType;
					//Console.WriteLine("i.IsStatic " + i.IsStatic);

					var subscribe = typeof(MsgcBase<>).MakeGenericType(new[] { tt }).GetMethod("Subscribe");
					var delegateType = typeof(Action<>).MakeGenericType(tt);
					var del = Delegate.CreateDelegate(delegateType, null, i);
					//It will never be null since it is getting from MsgcBase.
					subscribe.Invoke(null, new[] { o, del });



				}
			}
		}
		public static void UnsubscribeClass(object o)
		{
			Type c = o.GetType();

			var m = c.GetMethods();
			foreach (var i in m)
			{
				if (!i.IsStatic &&i.Name == FuncName)
				{
					var tt = i.GetParameters()[0].ParameterType;
					//var tt = mm[0].ParameterType;
					//Console.WriteLine("i.IsStatic " + i.IsStatic);

					var unsubscribe = typeof(MsgcBase<>).MakeGenericType(new[] { tt }).GetMethod("Unsubscribe");
					var delegateType = typeof(Action<>).MakeGenericType(tt);
					var del = Delegate.CreateDelegate(delegateType, null, i);
					//It will never be null since it is getting from MsgcBase.
					unsubscribe.Invoke(null, new[] { o, del });
				}
			}

		}


	}


	public class MessageBase : IDisposable
	{
		private bool MessageBaseDisposed = false;
		public MessageBase()
		{
			Msgc.SubscribeClass(this);
		}
		//Can also
		public void Dispose()
		{
			Dispose(disposing: true);
			// This object will be cleaned up by the Dispose method.
			// Therefore, you should call GC.SuppressFinalize to
			// take this object off the finalization queue
			// and prevent finalization code for this object
			// from executing a second time.
			GC.SuppressFinalize(this);
		}
		protected virtual void Dispose(bool disposing)
		{
			// Check to see if Dispose has already been called.
			if (!this.MessageBaseDisposed)
			{
				// If disposing equals true, dispose all managed
				// and unmanaged resources.
				if (disposing)
				{
					// Dispose managed resources.
					Msgc.UnsubscribeClass(this);
				}
				// Note disposing has been done.
				MessageBaseDisposed = true;
			}
		}
		~MessageBase()
		{

			Dispose(disposing: false);
		}
	}
}