using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    if(pin.Length != 4 && pin.Length != 6)
    {
    return false;
    }
    Regex rx = new Regex(@"^\d{4}$|^\d{6}$"); // Nur 4 oder 6 Zahlen
    return rx.IsMatch(pin) ? true : false;    
  }
}