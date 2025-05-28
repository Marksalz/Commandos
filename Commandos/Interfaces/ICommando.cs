using System;

namespace Commandos
{
    internal interface ICommando
    {
        string Name { get; set; }
        int CodeName { get; set; }
        void Walk();
        void Hide();
        void Attack();
        string SayName(string commanderRank);
    }
}