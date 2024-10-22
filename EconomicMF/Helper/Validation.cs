﻿using EconomicMF.Domain.Entities.Flows;
using RJCodeAdvance.RJControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EconomicMF.Helper
{
    public static class Validation
    {
        public static void PhoneValidation(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (e.KeyChar.Equals("-"))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void OnlyLetters(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        public static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan
                e.Handled = true;
            }
        }
        public static void ValidateRegister(string nombre, string dni, string telefono, string correo, string contrasena)
        {
            if (nombre != null && dni != null && telefono != null && correo != null && contrasena != null)
            {
                if (!Regex.IsMatch(dni, @"\A[0-9]{3}(\-)[0-9]{6}(\-)[0-9]{4}[A-Z]\Z"))
                {
                    throw new ArgumentException("Cédula invalida");

                }
                //if (!Regex.IsMatch(telefono, @"\A[0-9]{4}(\-)[0-9]{4}\Z"))
                //{
                //    throw new ArgumentException("Número de telefono invalido");

                //}
                if (!Regex.IsMatch(correo, @"\A(\w+\.?\w*\@\w+\.)(com)\Z"))
                {
                    throw new ArgumentException("correo electronico invalido");

                }
                //if (!Regex.IsMatch(contrasena, @"^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,25}$"))
                //{
                //    throw new ArgumentException("La contraseña debe tener como minimo 8 caracteres, (La contraseña debe tener al entre 8 y 16 caracteres, al menos un dígito, al menos una minúscula, al menos una mayúscula y al menos un caracter no alfanumérico(@ # % { ). etc.)");

                //}
            }
            else
            {
                throw new ArgumentNullException("No puede dejar espacios en blanco");
            }

        }
        public static void ValidateIngresoCosto(decimal ingresCost, int start, int end, int duracion)
        {
            if (ingresCost <= 0)
            {
                throw new ArgumentException("Ingrese un valor dentro del rango de duración de su proyecto");
            }
            if (duracion == 0)
            {
                throw new Exception(" el proyecto no puede durar cero años");
            }
            if (start <= 0 || start > end)
            {
                throw new Exception("valores invalidos ");

            };
            if (end <= 0 || end > duracion)
            {
                throw new Exception("El valor final no puede ser mayor a la duracion del proyecto");
            };
        }
        public static void ValidateInversion(decimal inversion, int start, int duracion)
        {
            if (inversion <= 0)
            {
                throw new Exception("La inversion no puede ser menor o igual a cero");
            }
            if (start <= 0 || start > duracion)
            {
                throw new InvalidOperationException("valores inavlidos para el comienzo del proyecto");
            }

        }
        public static void ValidateDecimalnotNegative(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                // solo 1 punto decimal
                if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((sender as RJTextBox).Texts.Contains(".") && (char)Keys.Back != e.KeyChar) {
                    if ((sender as RJTextBox).Texts.Substring((sender as RJTextBox).Texts.IndexOf('.')).Length > 4)
                    {
                        e.Handled = true;
                    }
                }else
                if((sender as RJTextBox).Texts.Length > 9 && (char)Keys.Back != e.KeyChar && '.' != e.KeyChar)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public static void ValidateDecimalNegative(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                }
                // solo 1 punto decimal
                if ((e.KeyChar == '.') && ((sender as RJTextBox).Texts.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '-') && ((sender as RJTextBox).Texts.IndexOf('-') > -1))
                {
                    e.Handled = true;
                }
                if ((sender as RJTextBox).Texts.Length > 0 && (e.KeyChar == '-') && (sender as RJTextBox).Texts.ToCharArray()[0] != '-')
                {
                    e.Handled = true;
                }
                if ((sender as RJTextBox).Texts.Contains(".") && (char)Keys.Back != e.KeyChar) {
                    if ((sender as RJTextBox).Texts.Substring((sender as RJTextBox).Texts.IndexOf('.')).Length > 4)
                    {
                        e.Handled = true;
                    }
                }
                else
                if ((sender as RJTextBox).Texts.Length > 9 && (char)Keys.Back != e.KeyChar && '.' != e.KeyChar)
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public static void ValidateStarEnd(int star, int end, int N)
        {
            try
            {

                if (star >= end)
                {
                    throw new ArgumentException("El inicio no puede ser mayor que el fin");
                }
                if (star == 0)
                {
                    throw new ArgumentException("El inicio no puede ser igual a 0");
                }
                if (end > N)
                {
                    throw new ArgumentException($"El fin no puede superar la duración del proyecto: {N}");
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
