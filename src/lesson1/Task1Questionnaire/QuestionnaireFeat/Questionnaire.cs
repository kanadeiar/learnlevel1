﻿namespace Task1Questionnaire.QuestionnaireFeat;

public class Questionnaire : ICommonQuestionnaire
{
    private readonly string _name;

    public string? Name => _name;

    private readonly string _surName;

    public string? SurName => _surName;

    private readonly int _age;

    public int Age => _age;

    private readonly int _height;

    public int Height => _height;

    private readonly int _weight;

    public int Weight => _weight;

    private FormatBase _typ = new FormatNone();

    public TextFormatCode Code => _typ.GetCode();

    public Questionnaire(string name, string surName, int age, int height, int weight)
    {
        _name = name;
        _surName = surName;
        _age = age;
        _height = height;
        _weight = weight;
    }

    public string GetText(TextFormatCode typ)
    {
        _typ = FormatBase.Create(typ);
        return formTextLineFromProperties();
    }

    private string formTextLineFromProperties()
    {
        return _typ.GetText(this);
    }
}