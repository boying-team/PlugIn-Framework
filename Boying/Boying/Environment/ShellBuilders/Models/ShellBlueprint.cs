﻿using System;
using System.Collections.Generic;
using Boying.Environment.Configuration;
using Boying.Environment.Descriptor.Models;
using Boying.Environment.Extensions.Models;

namespace Boying.Environment.ShellBuilders.Models
{
    /// <summary>
    /// Contains the information necessary to initialize an IoC container
    /// for a particular tenant. This model is created by the ICompositionStrategy
    /// and is passed into the IShellContainerFactory.
    /// </summary>
    public class ShellBlueprint
    {
        public ShellSettings Settings { get; set; }

        public ShellDescriptor Descriptor { get; set; }

        public IEnumerable<DependencyBlueprint> Dependencies { get; set; }

        public IEnumerable<ControllerBlueprint> Controllers { get; set; }

        public IEnumerable<ControllerBlueprint> HttpControllers { get; set; }

        public IEnumerable<RecordBlueprint> Records { get; set; }
    }

    public class ShellBlueprintItem
    {
        public Type Type { get; set; }

        public Feature Feature { get; set; }
    }

    public class DependencyBlueprint : ShellBlueprintItem
    {
        public IEnumerable<ShellParameter> Parameters { get; set; }
    }

    public class ControllerBlueprint : ShellBlueprintItem
    {
        public string AreaName { get; set; }

        public string ControllerName { get; set; }
    }

    public class RecordBlueprint : ShellBlueprintItem
    {
        public string TableName { get; set; }
    }
}