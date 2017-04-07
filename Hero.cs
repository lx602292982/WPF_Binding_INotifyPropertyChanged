using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace WpfApplication1
{
    class Hero : INotifyPropertyChanged
    {
      // INotifyPropertyChanged 成员
        public event PropertyChangedEventHandler PropertyChanged;
        public Hero(int id, string name, string skill, bool hasm)
        {
            this.Name = name;
            this.Id = id;
            this.Skill = skill;
            this.HasM = hasm;
        }

        public int Id { set; get; }
        public string name;
        public string Name 
        {
            set
            {
                name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
            get 
            {
                return name;
            }
        }
        public bool HasM { set; get; }
        public string skill;
        public string Skill
        {
            set {
                skill = value;
                if(PropertyChanged!=null)
                {
                  PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Skill"));
                }
            }
            get {
                return skill;
            } 
        }


        #region INotifyPropertyChanged 成员

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        #endregion
    }
}
