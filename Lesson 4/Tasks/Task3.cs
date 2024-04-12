namespace Lesson_4
{
    class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public int CVC { get;set; }
        public DateTime ExpiryDate { get;set; }

        public CreditCard(string cardNumber, string cardholderName, int cvc, DateTime expiryDate)
        {
            ValidateCardNumber(cardNumber);
            ValidateCVC(cvc);
            ValidateExpiryDate(expiryDate);

            CardNumber = cardNumber;
            CardholderName = cardholderName;
            CVC = cvc;
            ExpiryDate = expiryDate;
        }

        private void ValidateCardNumber(string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(cardNumber) || cardNumber.Length != 16)
            {
                throw new ArgumentException("Неправильний номер кредитної картки");
            }
        }

        private void ValidateCVC(int cvc)
        {
            if (cvc < 100 || cvc > 999)
            {
                throw new ArgumentException("Неправильний CVC");
            }
        }

        private void ValidateExpiryDate(DateTime expiryDate)
        {
            if (expiryDate <= DateTime.Now)
            {
                throw new ArgumentException("Неправильна дата закінчення дії картки");
            }
        }

    }

}
