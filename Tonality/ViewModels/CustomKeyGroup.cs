using System;
using System.Collections.Generic;
using System.Linq;
using Tonality.ViewModels;
using System.Text;
using System.Threading.Tasks;


namespace Tonality
{
    public class CustomKeyGroup<T> : List<T>
    {
        public static IEnumerable<SoundData> GetSoundList(List<SoundData> items)
        {
            List<SoundData> SoundList = new List<SoundData>();

            SoundList = items;
            return SoundList;
        }


        public static List<Group<SoundData>> GetSoundGroups(List<SoundData> items)
        {
            IEnumerable<SoundData> SoundList = GetSoundList(items);
            return GetItemGroups(SoundList, c => c.Groups);
        }


        public static List<Group<T>> GetItemGroups<T>(IEnumerable<T> itemList, Func<T, string> getKeyFunc)
        {
            IEnumerable<Group<T>> groupList = from item in itemList
                                              group item by getKeyFunc(item) into g
                                              orderby g.Key
                                              select new Group<T>(g.Key, g);

            return groupList.ToList();
        }


        public class Group<T> : List<T>
        {
            public Group(string name, IEnumerable<T> items)
                : base(items)
            {
                this.Groups = name;
            }

            public string Groups
            {
                get;
                set;
            }
        }

    }
}
