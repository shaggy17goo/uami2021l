﻿

namespace Model
{
  using Utilities;
  public partial class Model : PropertyContainerBase, IModel
  {
    public Model( IEventDispatcher dispatch ) : base( dispatch )
    {
    }
  }
}
