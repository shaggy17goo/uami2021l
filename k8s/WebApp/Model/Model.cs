﻿using Utilities;

namespace Model
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public partial class Model : PropertyContainerBase, IModel
  {
    public Model( IEventDispatcher dispatch ) : base( dispatch )
    {
    }
  }
}