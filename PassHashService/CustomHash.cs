using EasyEncryption;

namespace ServiceAcount.PassHash
{
    public static class CustomHash
    {
		public static string HashPassword(string input)
		{ 
			return SHA.ComputeSHA256Hash(input);
		}

		public static bool PasswordCheck(string userInput, string savedInDbPassword)
		{ 
			string hashedInput = HashPassword(userInput);
			bool doPasswordsMatch = string.Equals(hashedInput, savedInDbPassword);
			return doPasswordsMatch;
		}
	}
}
