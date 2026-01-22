namespace MyModels;

public class MyList<CustomType>
{
    public CustomType[] NewList = new CustomType[0];

    public void Add(CustomType num)
    {
        Array.Resize(ref NewList, NewList.Length+1);
        NewList[NewList.Length-1] = num;
    }
    public void Remove(CustomType input)
    {
        bool IsExist = false;
        CustomType[] FilteredArray = new CustomType[NewList.Length-1];
        for(int i=0; i<NewList.Length-1; i++)
        {
            // if(NewList[i] == input)
            if(EqualityComparer<CustomType>.Default.Equals(NewList[i], input))
            {
                IsExist = true;
                continue;
            }
            else {
                if(IsExist)
                {
                    FilteredArray[i] = NewList[i+1];
                }
                else
                {
                    FilteredArray[i] = NewList[i];
                }
            }
        }
        NewList = FilteredArray;
    }
    public void Clear()
    {
        NewList = new CustomType[0];
    }
    public bool Contains(CustomType input)
    {
        for(int i=0; i<NewList.Length; i++)
        {
            // if(NewList[i] == input)
            if(EqualityComparer<CustomType>.Default.Equals(NewList[i], input))
            {
                return true;
            }
        }
        return false;
    }
    public int Count()
    {
        return NewList.Length;
    }
}
