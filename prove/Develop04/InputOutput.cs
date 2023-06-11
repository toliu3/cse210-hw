using System;
using System.IO;
using System.Collections.Generic;

public class InputOutput
{
    private int _n0; int _n1; int _n2;
    private string _fileName = "record.txt";
    public void Write(int n0, int n1, int n2)
    {
        _n0 += n0; _n1 += n1; _n2 += n2;
        List<string> myList = new List<string> { _n0.ToString(), _n1.ToString(), _n2.ToString() };

        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (string item in myList)
            {
                writer.WriteLine(item);
            }
        }
    }

    public void Load()
    {
        string[] lines = File.ReadAllLines(_fileName);

        _n0 = int.Parse(lines[0]);
        _n1 = int.Parse(lines[1]);
        _n2 = int.Parse(lines[2]);
    }

    public int Getn0()
    {
        return _n0;
    }
    public int Getn1()
    {
        return _n1;
    }    
    public int Getn2()
    {
        return _n2;
    }
}