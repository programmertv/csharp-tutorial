using System;
using System.Collections.Generic;

namespace Episode009
{
    public class Person
    {
        #region -- Fields --

        private string _firstName;

        #endregion

        #region -- Constructor --

        public Person()
        {
        }

        public Person(string first)
        {
            FirstName = first;
        }

        public Person(string first, string last): this(first)
        {
            LastName = last;
        }

        #endregion

        #region -- Properties --

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Sample { get; private set; }
        private string _nickName;
        public string NickName
        {
            get
            {                
                if (string.IsNullOrEmpty(_nickName))
                    return "N/A";

                return _nickName;
            }
            set
            {
                if (value == null)
                    _nickName = string.Empty;
                else
                    _nickName = value;

            }
        }
        public DateTime? BirthDate { get; set; }
        public List<Fruit> FavoriteFruits { get; set; } = new List<Fruit>();

        #endregion

        #region -- Methods --

        public void AddFavoriteFruit(Fruit fruit, ProcessFruitDelegate successCallback)
        {
            FavoriteFruits.Add(fruit);
            successCallback(fruit);
        }

        public void DeleteFavoriteFruit(Fruit fruit, ProcessFruitDelegate successCallback)
        {
            FavoriteFruits.Remove(fruit);
            successCallback(fruit);
        }


        public void Update(int sample)
        {
            Sample = sample;
        }

        public void Update(int sample, string nickName)
        {
            Update(sample);
            NickName = nickName;
            NickNameHandler?.Invoke(this, new NickNameArgs { NickName = nickName });
        }

        public int? GetAge()
        {
            if (BirthDate.HasValue)
            {
                return (int?)((DateTime.Now - BirthDate.Value).TotalDays / 365);
            }

            return default;
        }

        #endregion

        #region -- Events --

        public event EventHandler<NickNameArgs> NickNameHandler;
        public event ProcessFruitDelegate FruitHandler;

        #endregion

    }

    public class NickNameArgs: EventArgs
    {
        public string NickName { get; set; }
    }
}

//Main Class
public class MainClass
{
    //Private Class
    private class SubClass
    {

    }

    //Protected Class
    protected class SubClassNumber2
    {

    }
}