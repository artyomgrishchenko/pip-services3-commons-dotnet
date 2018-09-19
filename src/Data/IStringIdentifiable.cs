﻿namespace PipServices.Commons.Data
{
    /// <summary>
    /// Interface for data objects that can be uniquely identifed by a string id. 
    /// 
    /// The interface extends IIdentifiable to hardcode id type to string.
    /// 
    /// It is a common pattern to use a string GUID as the id, generated by IdGenerator.
    /// </summary>
    /// <example>
    /// <code>
    /// public class MyData: IIdentifiable<String> 
    /// {
    ///     string id {get; set;}
    ///     string field1;
    ///     int field2;
    ///     ...
    /// }
    /// </code>
    /// </example>
    /// See <see cref="IIdentifiable{T}"/>, <see cref="IdGenerator"/>
    public interface IStringIdentifiable : IIdentifiable<string>
    {
    }
}
