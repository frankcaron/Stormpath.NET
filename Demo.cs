using System;

namespace StormpathAPIDemo
{
	public class Demo
	{
		public static void Main (string[] args)
		{
			string user, pass, email;

			StormpathAuth stormpath = new StormpathAuth ("YOUR_APP_ID_HERE","YOUR_APP_KEY_ID_HERE","YOUR_APP_KEY_SECRET_HERE");
			Console.WriteLine ("Welcome to Stormpath API Demo!  What username do you want?\n");
			user = Console.ReadLine ();
			Console.WriteLine ("Great! Now what's your desired password?\n");
			pass = Console.ReadLine ();
			Console.WriteLine ("Cool!  Email?\n");
			email = Console.ReadLine ();
			Console.WriteLine ("Making an account...\n");
			if (stormpath.CreateAccount (user, email, pass)) {
				Console.WriteLine ("...Successfully made account!  Attemping to login...\n");
				if (stormpath.Login (user, pass))
					Console.WriteLine ("...Successfully logged in! Wasn't that awesome?\n");
				else
					Console.WriteLine ("...Failed to login XD\n");
			} else {
				Console.WriteLine ("...Failed to create account! Please check your app info.\n");

			}

		}
	}
}

