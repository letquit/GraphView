using UnityEngine.UIElements;

[UxmlElement]
public partial class SplitView : TwoPaneSplitView  // 添加 partial 关键字
{
    public SplitView()
    {
        orientation = TwoPaneSplitViewOrientation.Horizontal;
    }
}