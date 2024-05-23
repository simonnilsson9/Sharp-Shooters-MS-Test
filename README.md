# Unit Testing for Bank Application

## Currency

### 1. Test_ConvertCurrency_SameCurrency_Return_SameAmount
Testar att konvertera pengar från en valuta till samma valuta och kontrollerar att resultatet är samma som ingångsvärdet.

### 2. Test_ConvertCurrency_DifferentCurrency_Return_CorrectConversion
Testar att konvertera pengar från en valuta till en annan och kontrollerar att resultatet är korrekt baserat på en fördefinierad växelkurs.

### 3. Test_ConvertCurrency_InvalidCurrency_Return_NoConversion
Testar att försöka konvertera pengar med en ogiltig valuta och kontrollerar att summan förblir densamma och att ingen konvertering sker.

### 4. Test_ConvertCurrency_NullAmount_Return_0
Testar att skicka in `null` som belopp och kontrollerar att resultatet blir 0.

## TransferCallback

### 1. Test_TransferCallback_Return_CorrectBalance
Testar att överföra pengar mellan två konton och kontrollerar att beloppen på båda kontona justeras korrekt.

### 2. Test_TransferCallback_Return_CheckTransactionHistory
Testar att överföra pengar mellan två konton och kontrollerar att transaktionshistoriken uppdateras korrekt för både avsändaren och mottagaren.

### 3. Test_TransferCallback_InvalidAmount_Return_NoTransfer
Testar att försöka överföra ett ogiltigt belopp och kontrollerar att transaktionen inte genomförs.

## InitializeUser

### 1. Test_InitializeUser_CreatesCorrectNumberOfUsers_Return_4
Testar att användarinitialiseringsmetoden skapar exakt 4 användare och returnerar fail om antalet användare inte stämmer.

### 2. Test_InitializeUser_UsersHaveCorrectUsernameAndPinCode
Testar att användarens namn och pinkod matchar förväntade värden och kontrollerar att användardata är korrekt.
