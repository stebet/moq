﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Moq.Sdk;
using Stunts;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

public class FooMock : IStunt, IMocked, IDisposable, IFormatProvider, INotifyPropertyChanged
{
    readonly BehaviorPipeline pipeline = new BehaviorPipeline();
    IMock mock;

    [CompilerGenerated]
    ObservableCollection<IStuntBehavior> IStunt.Behaviors => pipeline.Behaviors;

    [CompilerGenerated]
    IMock IMocked.Mock => LazyInitializer.EnsureInitialized(ref mock, () => new MockInfo(this));

    [CompilerGenerated]
    public void Dispose() => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod()));
    [CompilerGenerated]
    public override bool Equals(object obj) => pipeline.Execute<bool>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), obj));

    [CompilerGenerated]
    public object GetFormat(Type formatType) => pipeline.Execute<object>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), formatType));
    [CompilerGenerated]
    public override int GetHashCode() => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));
    [CompilerGenerated]
    public override string ToString() => pipeline.Execute<string>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

    [CompilerGenerated]
    public event PropertyChangedEventHandler PropertyChanged
    {
        add => pipeline.Execute<PropertyChangedEventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value));
        remove => pipeline.Execute<PropertyChangedEventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value));
    }
}