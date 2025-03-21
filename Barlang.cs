﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarlangokGUI;

internal class Barlang
{
    private int melyseg = 0;
    private int hossz = 0;

    public int Azon { get; private set; }
    public string Nev { get; private set; }

    public int Hossz
    {
        get
        {
            return hossz;
        }
        set
        {
            if (value >= hossz)
            {
                hossz = value;
            }
        }
    }

    public int Melyseg
    {
        get
        {
            return melyseg;
        }
        set
        {
            if (value >= melyseg)
            {
                melyseg = value;
            }
        }
    }

    public string Telepules { get; private set; }
    public string Vedettseg { get; private set; }

    public Barlang(string sor)
    {
        string[] m = sor.Split(';');
        Azon = int.Parse(m[0]);
        Nev = m[1];
        Hossz = int.Parse(m[2]);
        Melyseg = int.Parse(m[3]);
        Telepules = m[4];
        Vedettseg = m[5];
    }

    public override string ToString()
    {
        return $"\tAzon: {Azon}\n\tNév: {Nev}\n\tHossz: {Hossz} m\n\tMélység: {Melyseg} m\n\tTelepülés: {Telepules}";
    }
}
