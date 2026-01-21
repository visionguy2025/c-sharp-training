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
        int RemovedIndex = 0;
        CustomType FilteredArray = new CustomType[NewList.Length-1];
        for(int i=0; i<NewList.Length-1; i++)
        {
            if(NewList[i] == input)
            {
                IsExist = true;
            }
            else if(NewList[i] != input)
            {
                FilteredArray[i] = element;
            }
        }
    }
    public void Clear()
    {
        NewList = new CustomType[0];
    }
    // public bool Contains(CustomType input)
    // {
    //     for(int i=0; i<NewList.Length; i++)
    //     {
    //         if(NewList[i] == input)
    //         {
    //             return true;
    //         }
    //         return false;
    //     }
    // }
    public int Count()
    {
        return NewList.Length;
    }
}
