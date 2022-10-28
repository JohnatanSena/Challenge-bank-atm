using Challenge_bank_atm;

Console.WriteLine("Qual valor do saque");
var atm = new AtmSystem();
var withdrawValue = Convert.ToInt32(Console.ReadLine());
atm.CalculateBankNotes(withdrawValue);

namespace Challenge_bank_atm
{

    public class AtmSystem
    {
        public void CalculateBankNotes(long withdrawValue)
        {
            int ced = 100;
            int totalced = 0;
            var result = "";

            while (true)
            {
                if (withdrawValue >= ced)
                {
                    withdrawValue -= ced;
                    totalced += 1;
                }

                else
                {
                    if (totalced > 0)
                    {
                        result += $"{totalced} de R$ {ced},00 \n";
                    }

                    if (ced == 100)
                    {
                        ced = 50;
                    }
                    else if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;

                    }
                    else if (ced == 10)
                    {
                        ced = 5;
                    }

                    else
                    {
                        ced = 2;
                    }
                    totalced = 0;

                    if (withdrawValue == 0 || withdrawValue == 1)
                    {
                        break;
                    }
                }

            }
            if (withdrawValue == 1)
            {
                Console.WriteLine("Valor do saque invalido");

            }
            else if (withdrawValue == 0)
            {
                Console.WriteLine(result);
            }

        }
    }
}


