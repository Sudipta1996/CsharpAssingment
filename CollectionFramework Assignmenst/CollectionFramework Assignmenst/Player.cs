using System;
using System.Collections;

namespace CollectionFramework_Assignmenst
{
    
    public class Player
    {
        public Player(string fName, int runScore)
        {
            this.firstName = fName;
            this.runScore = runScore;
        }

        public string firstName;
        public int runScore;
    }

    
    public class Team : IEnumerable
    {
        private Player[] team;
        public Team(Player[] pArray)
        {
            team = new Player[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                team[i] = pArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public TeamEnum GetEnumerator()
        {
            return new TeamEnum(team);
        }
    }

    
    public class TeamEnum : IEnumerator
    {
        public Player[] team;

        
        int position = -1;

        public TeamEnum(Player[] list)
        {
            team = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < team.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Player Current
        {
            get
            {
                try
                {
                    return team[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }

    class Yoo
    {
        static void Main()
        {
            Player[] peopleArray = new Player[3]
            {
            new Player("John", 200),
            new Player("Jim", 150),
            new Player("Sue", 300),
            };

            Team India = new Team(peopleArray);
            foreach (Player p in India)
                Console.WriteLine(p.firstName + " " + p.runScore);
            Console.ReadKey();
        }
    }
}
