// Copyright (c) Microsoft.
// Licensed under the MIT license.

using System;
using System.Collections;
#pragma warning disable 1590,1591,1592,1573,1571,1570,1572,1587



using Microsoft.SqlServer.Management.Sdk.Sfc;



































namespace Microsoft.SqlServer.Management.Smo
{

    ///<summary>
    /// Strongly typed list of MAPPED_TYPE objects
    /// Has strongly typed support for all of the methods of the sorted list class
    ///</summary>
    public sealed  class DatabaseScopedCredentialCollection : SimpleObjectCollectionBase
	{


















		internal DatabaseScopedCredentialCollection(SqlSmoObject parentInstance)  : base(parentInstance)
		{
		}



		public Database Parent
		{
			get
			{
				return this.ParentInstance as Database;
			}
		}

		
		public DatabaseScopedCredential this[Int32 index]
		{
			get
			{ 
				return GetObjectByIndex(index) as DatabaseScopedCredential;
			}
		}


		// returns wrapper class
		public DatabaseScopedCredential this[string name]
		{
			get
			{
                





    
	    			    return  GetObjectByName(name) as DatabaseScopedCredential;
                    
                



















			}
		}


		public void CopyTo(DatabaseScopedCredential[] array, int index)
		{
			((ICollection)this).CopyTo(array, index);
		}
		

		public DatabaseScopedCredential ItemById(int id)
		{
			return (DatabaseScopedCredential)GetItemById(id);
		}


































		protected override Type GetCollectionElementType()
		{
			return typeof(DatabaseScopedCredential);
		}

		internal override SqlSmoObject GetCollectionElementInstance(ObjectKeyBase key, SqlSmoState state)
		{
			return  new DatabaseScopedCredential(this, key, state);
		}



















		public void Add(DatabaseScopedCredential databaseScopedCredential) 
		{
			AddImpl(databaseScopedCredential);
		}


		internal SqlSmoObject GetObjectByName(string name)
		{
			return GetObjectByKey(new SimpleObjectKey(name));
		}


		internal override ObjectKeyBase CreateKeyFromUrn(Urn urn)
		{ 
			string name = urn.GetAttribute("Name");



            if( null == name || name.Length == 0)

				throw new SmoException(ExceptionTemplates.PropertyMustBeSpecifiedInUrn("Name", urn.Type));
            return new SimpleObjectKey(name);        
        }


















	}
}
