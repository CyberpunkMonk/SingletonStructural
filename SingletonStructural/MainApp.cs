using System;

namespace SingletonStructural {
	/// <summary>
	/// MainApp startup class
	/// </summary>
	class MainApp {
		/// <summary>
		/// Defines the entry point of the application.
		/// </summary>
		static void Main() {
			//C'tor is protected
			Singleton s1 = Singleton.Instance();
			Singleton s2 = Singleton.Instance();

			//test for same instance;
			if (s1 == s2) Console.WriteLine("Objects are the same instnace.");
			//Wait for user
			Console.ReadKey();
		}
	}
}
