using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios.Pages {
    partial class Ejercicio3 {
        static public bool ValidarCedula(char[] cedula) {
            int suma = 0;
            int division;

            char[] peso = { '1', '2', '1', '2', '1', '2', '1', '2', '1', '2' };

            if (cedula.Length != 11)
                return false;

            else {
                for (int i = 0; i < 10; i++) {

                    if (!char.IsDigit(cedula[i]))
                        return false;

                    int a = int.Parse(cedula[i].ToString());
                    int b = int.Parse(peso[i].ToString());

                    char[] mult = (a * b).ToString().ToCharArray();

                    if (mult.Length > 1) {
                        a = int.Parse(mult[0].ToString());
                        b = int.Parse(mult[1].ToString());
                    } else {
                        a = 0;
                        b = int.Parse(mult[0].ToString());
                    }
                    suma += a + b;
                }

                division = (suma / 10) * 10;

                if (division < suma)
                    division += 10;

                int digito = division - suma;

                if (digito != int.Parse(cedula[10].ToString()))
                    return false;
            }

            return true;
        }
    }
}
