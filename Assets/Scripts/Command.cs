using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{
    public abstract void execute();
}

public class MoveLeft : Command
{
    public override void execute()
    {
        GridManager.MoveLeft();
    }
}

public class MoveRight : Command
{
    public override void execute()
    {
        GridManager.MoveRight();
    }
}

public class MoveUp : Command
{
    public override void execute()
    {
        GridManager.MoveUp();
    }
}

public class MoveDown : Command
{
    public override void execute()
    {
        GridManager.MoveDown();
    }
}

