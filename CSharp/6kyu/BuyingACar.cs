namespace CSharp._6kyu;

public class BuyingACar
{
    public static int[] nbMonths(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth) {
        int month = 0;
        double savingMoney = 0;
        var startPriceOldDouble = Convert.ToDouble(startPriceOld);
        var startPriceNewDouble = Convert.ToDouble(startPriceNew);

        while(savingMoney + startPriceOldDouble < startPriceNewDouble)
        {
            month++;
            if(month % 2 == 0 && month != 0)
                percentLossByMonth += 0.5;

            startPriceOldDouble -= startPriceOldDouble / 100 * percentLossByMonth;
            startPriceNewDouble -= startPriceNewDouble / 100 * percentLossByMonth;
            savingMoney += savingPerMonth;
        }
        savingMoney = savingMoney + startPriceOldDouble - startPriceNewDouble;
        int[] result = new[]{month, (int)Math.Round(savingMoney, 0, MidpointRounding.AwayFromZero)};
        return result;
    }
}