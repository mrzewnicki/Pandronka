using Pandronka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pandronka.Utility
{
    public static class SD
    {
        public const string DefaultFoodImage = "pandrona.png";


        public const string ManagerUser = "Manager";
        public const string CourierUser = "Kurier";
        public const string CustomerEndUser = "Kupiec";

        public const string ssShoppingCartCount = "ssCartCount";

        public const string StatusSubmitted = "Przyjęty";
        public const string StatusInProcess = "W przygotowaniu";
        public const string StatusReady = "Gotowy do odbioru";
        public const string StatusCompleted = "Przygotowany kurier wiezie";
        public const string StatusCancelled = "Anulowany";

        public const string PaymentStatusPending = "W trakcie";
        public const string PaymentStatusApproved = "Zaakceptowany";
        public const string PaymentStatusRejected = "Odrzucony";

        public static string ConvertToRawHtml(string source)
        {
            if (source != null)
            {
                char[] array = new char[source.Length];
                int arrayIndex = 0;
                bool inside = false;

                for (int i = 0; i < source.Length; i++)
                {
                    char let = source[i];
                    if (let == '<')
                    {
                        inside = true;
                        continue;
                    }
                    if (let == '>')
                    {
                        inside = false;
                        continue;
                    }
                    if (!inside)
                    {
                        array[arrayIndex] = let;
                        arrayIndex++;
                    }
                }
                return new string(array, 0, arrayIndex);
            }
            else
                return null;
        }
    }
}
