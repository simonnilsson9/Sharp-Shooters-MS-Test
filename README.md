# Unit Testing for Bank Application

## Currency

### 1. TestUsdToEuro_Return_Euro_ExRate
Verifierar att växelkursen från USD till Euro korrekt returneras som 0,93.

### 2. TestUsdToKronor_Return_Kr_ExRate
Kontrollerar att växelkursen från USD till Svenska kronor korrekt returneras som 10,86.

### 3. TestEuroToUsd_Return_Usd_ExRate
Säkerställer att växelkursen från Euro till USD korrekt returneras som 1,07.

### 4. TestEuroToKronor_Return_Kr_ExRate
Validerar att växelkursen från Euro till Svenska kronor korrekt returneras som 11,68.

### 5. TestKronorToUsd_Return_Usd_ExRate
Bekräftar att växelkursen från Svenska kronor till USD korrekt returneras som 0,10.

### 6. TestKronorToEuro_Return_Euro_ExRate
Kontrollerar att växelkursen från Svenska kronor till Euro korrekt returneras som 0,091.

### 7. TestSameCurrency_Return_Same
Verifierar att växling av samma valuta (USD till USD) returnerar en växelkurs på 1,0.

### 8. TestUnknownCurrency_Return_Same
Säkerställer att växling från en okänd valuta (GBP) till USD standardiseras till en växelkurs på 1,0.

## TransferCallback

### 1. Test_TransferCallback_Return_CorrectBalance
Testar att överföra pengar mellan två konton och kontrollerar att beloppen på båda kontona justeras korrekt, samt att rätt meddelande skrivs ut.

### 2. Test_TransferCallback_InvalidAmount_Return_NoTransfer
Testar att försöka överföra ett ogiltigt belopp och kontrollerar att transaktionen inte genomförs.

## InitializeUser

### 1. Test_InitializeUser_CreatesCorrectNumberOfUsers_Return_4
Testar att användarinitialiseringsmetoden skapar exakt 4 användare och returnerar fail om antalet användare inte stämmer.

### 2. Test_InitializeUser_UsersHaveCorrectUsernameAndPinCode
Testar att användarens namn och pinkod matchar förväntade värden och kontrollerar att användardata är korrekt.
