using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpeedUnitCalculatorVb
{
    static class Program
    {
        private const double kilometrosXmillas = 1.609d;
        private const double nudosXmillas = 0.869d;

        public enum SpeedUnit
        {
            KilometrosHora = 1,
            Millas,
            Nudos
        }

        public static void Main(string[] args)
        {
            test();
            char tecla;
            do
            {
                SpeedUnit originalSpeedUnit;
                originalSpeedUnit = GetSpeedUnit("original");
                decimal speedValue;
                speedValue = GetSpeedValue();
                SpeedUnit equivalentSpeedUnit;
                equivalentSpeedUnit = GetSpeedUnit("equivalente");
                decimal result = ConvertSpeedUnit(originalSpeedUnit, speedValue, equivalentSpeedUnit);
                Console.WriteLine($"{originalSpeedUnit}: {speedValue} => {equivalentSpeedUnit}: {result}");
                Console.WriteLine("¿Desea hacer otro calculo? (<S> afirmativo, cualquier otra tecla para salir)");
                tecla = Console.ReadKey().KeyChar;
            }
            while (Conversions.ToString(tecla) == "S");
        }

        public static void test()
        {
            Assert.AreEqual(160.9m, ConvertSpeedUnit(SpeedUnit.Millas, 100m, SpeedUnit.KilometrosHora));
            Assert.AreEqual(86.9m, ConvertSpeedUnit(SpeedUnit.Millas, 100m, SpeedUnit.Nudos));
            Assert.AreEqual(62.150403977625854568054692356m, ConvertSpeedUnit(SpeedUnit.KilometrosHora, 100m, SpeedUnit.Millas));
            Assert.AreEqual(54.008701056556867619639527657m, ConvertSpeedUnit(SpeedUnit.KilometrosHora, 100m, SpeedUnit.Nudos));
            Assert.AreEqual(185.15535097813578826237054085m, ConvertSpeedUnit(SpeedUnit.Nudos, 100m, SpeedUnit.KilometrosHora));
            Assert.AreEqual(115.07479861910241657077100115m, ConvertSpeedUnit(SpeedUnit.Nudos, 100m, SpeedUnit.Millas));
        }

        public static decimal ConvertSpeedUnit(SpeedUnit original, decimal value, SpeedUnit equivalent)
        {
            if (original == equivalent)
            {
                return value;
            }
            decimal result = 0;
            switch (original)
            {
                case SpeedUnit.KilometrosHora:
                    {
                        result = value / (decimal)kilometrosXmillas;
                        if (equivalent == SpeedUnit.Nudos)
                        {
                            result = ConvertSpeedUnit(SpeedUnit.Millas, result, SpeedUnit.Nudos);
                        }
                        break;
                    }
                case SpeedUnit.Millas:
                    {
                        if (equivalent == SpeedUnit.KilometrosHora)
                        {
                            result = value * (decimal)kilometrosXmillas;
                        }
                        else
                        {
                            result = value * (decimal)nudosXmillas;
                        }
                        break;
                    }
                case SpeedUnit.Nudos:
                    {
                        result = value / (decimal)nudosXmillas;
                        if (equivalent == SpeedUnit.KilometrosHora)
                        {
                            result = ConvertSpeedUnit(SpeedUnit.Millas, result, SpeedUnit.KilometrosHora);
                        }
                        break;
                    }
            }
            return result;
        }
        public static SpeedUnit GetSpeedUnit(string mensaje)
        {
            SpeedUnit value;
            do
            {
                Console.WriteLine("Unidades de medida");
                foreach (var item in Enum.GetValues(typeof(SpeedUnit)))
                    Console.WriteLine($"{item:D}) {item}");
                Console.WriteLine($"Ingrese unidad de medida de {mensaje}: ");
                value = (SpeedUnit)Conversions.ToInteger(Console.ReadLine());
                if (!isValidSpeedUnit(value))
                {
                    Console.WriteLine("Selección inválidad");
                }
            }
            while (!isValidSpeedUnit(value));
            return value;
        }
        private static bool isValidSpeedUnit(SpeedUnit value)
        {
            return Enum.IsDefined(typeof(SpeedUnit), value);
        }
        public static decimal GetSpeedValue()
        {
            decimal value;
            do
            {
                Console.Write("Ingrese velocidad: ");
                value = Conversions.ToDecimal(Console.ReadLine());
                if (!isValidSpeedValue(value))
                {
                    Console.WriteLine("Velocidad inválida");
                }
            }
            while (!isValidSpeedValue(value));
            return value;
        }
        private static bool isValidSpeedValue(decimal value)
        {
            return value > 0m;
        }
    }
}