using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class NYUGameCenterStudent : NYUStudent
{
    
    // public string name;
    // public string netId;
    // public string type;
    // public float gpa = 4.0f;
    // public int credits = 0;

    public string[] professors;

    /*public NYUGameCenterStudent()
    {
        name = "NYU game student name";
        netId = "aa000";
        type = "NYU game center student";
        gpa = 4.0f;
        credits = 0;
        professors = new string[] { "Matt Parker", "Eric Zimmerman" };
    }*/

    public NYUGameCenterStudent(string name, string netId, float gpa, int credits, string[] professors)
        : base(name, netId, gpa, credits)
    {
        this.professors = professors;
    }

    public override string ShowRecord()
    {
        string professorText = "Professors : ";
        foreach (var name in professors )
        {
            professorText += name + "\n";
        }
        
        return base.ShowRecord() + "\n" + professorText;
    }
}
