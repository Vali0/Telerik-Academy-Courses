using System;
using System.Collections.Generic;

class Operators
{
    private List<char> arithmeticOperations = new List<char>() { '+', '-', '*', '/' };

    public List<char> ArithmeticOperators
    {
        get
        {
            return this.arithmeticOperations;
        }
    }

    private List<string> functions = new List<string>() { "pow", "sqrt", "ln" };

    public List<string> Funcions
    {
        get
        {
            return this.functions;
        }
    }

    private List<char> brackets = new List<char>() { '(', ')' };

    public List<char> Brackets
    {
        get
        {
            return this.brackets;
        }
    }
}