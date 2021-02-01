// Generated by Haxe 4.1.1

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._IntMap {
	public sealed class IntMapKeyIterator<T> : global::haxe.lang.HxObject, global::haxe.ds._IntMap.IntMapKeyIterator {
		
		static bool __hx_init_called = false;
		static IntMapKeyIterator() {
			if(global::haxe.ds._IntMap.IntMapKeyIterator<object>.__hx_init_called) return;
			global::haxe.ds._IntMap.IntMapKeyIterator<object>.__hx_init_called = true;
			unchecked{
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{407283053, 1224901875}, new string[]{"hasNext", "next"});
			}
			
		}
		#line default
		
		public IntMapKeyIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public IntMapKeyIterator(global::haxe.ds.IntMap<T> m) {
			#line 476 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::haxe.ds._IntMap.IntMapKeyIterator<object>.__hx_ctor_haxe_ds__IntMap_IntMapKeyIterator<T>(((global::haxe.ds._IntMap.IntMapKeyIterator<T>) (this) ), ((global::haxe.ds.IntMap<T>) (m) ));
		}
		#line default
		
		private static void __hx_ctor_haxe_ds__IntMap_IntMapKeyIterator<T_c>(global::haxe.ds._IntMap.IntMapKeyIterator<T_c> __hx_this, global::haxe.ds.IntMap<T_c> m) {
			#line 477 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			__hx_this.i = 0;
			__hx_this.m = m;
			#line 479 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			__hx_this.len = m.nBuckets;
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.ds._IntMap.IntMapKeyIterator me) {
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			return ( (( me != null )) ? (me.haxe_ds__IntMap_IntMapKeyIterator_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public object haxe_ds__IntMap_IntMapKeyIterator_cast<T_c>() {
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				return this;
			}
			
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::haxe.ds._IntMap.IntMapKeyIterator<T_c> new_me = new global::haxe.ds._IntMap.IntMapKeyIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			int i = 0;
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			while (( i < fields.length )) {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				string field = fields[i++];
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.ds.IntMap<T> m;
		
		public int i;
		
		public int len;
		
		public bool hasNext() {
			unchecked {
				#line 483 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				{
					#line 483 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					int _g = this.i;
					#line 483 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					int _g1 = this.len;
					#line 483 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					while (( _g < _g1 )) {
						#line 483 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						int j = _g++;
						if (( (( ((int) (( ((uint) (this.m.flags[( j >> 4 )]) ) >> (( (( j & 15 )) << 1 )) )) ) & 3 )) == 0 )) {
							#line 485 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
							this.i = j;
							return true;
						}
						
					}
					
				}
				
				#line 489 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				return false;
			}
			#line default
		}
		
		
		public int next() {
			#line 493 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			int ret = this.m._keys[this.i];
			#line 495 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			this.m.cachedIndex = this.i;
			this.m.cachedKey = ret;
			#line 498 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			this.i++;
			return ret;
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.len = ((int) (@value) );
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 105:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.i = ((int) (@value) );
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					default:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 105:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 109:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.m = ((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (@value) ))) );
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					default:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5393365:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.len;
					}
					
					
					case 105:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.i;
					}
					
					
					case 109:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.m;
					}
					
					
					default:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((double) (this.len) );
					}
					
					
					case 105:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((double) (this.i) );
					}
					
					
					default:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("len");
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("i");
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("m");
			#line 471 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._IntMap {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds._IntMap.IntMapKeyIterator<object>))]
	public interface IntMapKeyIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds__IntMap_IntMapKeyIterator_cast<T_c>();
		
		bool hasNext();
		
		int next();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._IntMap {
	public sealed class IntMapValueIterator<T> : global::haxe.lang.HxObject, global::haxe.ds._IntMap.IntMapValueIterator {
		
		static bool __hx_init_called = false;
		static IntMapValueIterator() {
			if(global::haxe.ds._IntMap.IntMapValueIterator<object>.__hx_init_called) return;
			global::haxe.ds._IntMap.IntMapValueIterator<object>.__hx_init_called = true;
			unchecked{
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				global::haxe.lang.FieldLookup.addFields(new int[]{407283053, 1224901875}, new string[]{"hasNext", "next"});
			}
			
		}
		#line default
		
		public IntMapValueIterator(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public IntMapValueIterator(global::haxe.ds.IntMap<T> m) {
			#line 509 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::haxe.ds._IntMap.IntMapValueIterator<object>.__hx_ctor_haxe_ds__IntMap_IntMapValueIterator<T>(((global::haxe.ds._IntMap.IntMapValueIterator<T>) (this) ), ((global::haxe.ds.IntMap<T>) (m) ));
		}
		#line default
		
		private static void __hx_ctor_haxe_ds__IntMap_IntMapValueIterator<T_c>(global::haxe.ds._IntMap.IntMapValueIterator<T_c> __hx_this, global::haxe.ds.IntMap<T_c> m) {
			#line 510 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			__hx_this.i = 0;
			__hx_this.m = m;
			#line 512 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			__hx_this.len = m.nBuckets;
		}
		#line default
		
		public static object __hx_cast<T_c_c>(global::haxe.ds._IntMap.IntMapValueIterator me) {
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			return ( (( me != null )) ? (me.haxe_ds__IntMap_IntMapValueIterator_cast<T_c_c>()) : default(object) );
		}
		#line default
		
		public object haxe_ds__IntMap_IntMapValueIterator_cast<T_c>() {
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				return this;
			}
			
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::haxe.ds._IntMap.IntMapValueIterator<T_c> new_me = new global::haxe.ds._IntMap.IntMapValueIterator<T_c>(((global::haxe.lang.EmptyObject) (global::haxe.lang.EmptyObject.EMPTY) ));
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			global::Array<string> fields = global::Reflect.fields(this);
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			int i = 0;
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			while (( i < fields.length )) {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				string field = fields[i++];
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			return new_me;
		}
		#line default
		
		public global::haxe.ds.IntMap<T> m;
		
		public int i;
		
		public int len;
		
		public bool hasNext() {
			unchecked {
				#line 516 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				{
					#line 516 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					int _g = this.i;
					#line 516 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					int _g1 = this.len;
					#line 516 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
					while (( _g < _g1 )) {
						#line 516 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						int j = _g++;
						if (( (( ((int) (( ((uint) (this.m.flags[( j >> 4 )]) ) >> (( (( j & 15 )) << 1 )) )) ) & 3 )) == 0 )) {
							#line 518 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
							this.i = j;
							return true;
						}
						
					}
					
				}
				
				#line 522 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				return false;
			}
			#line default
		}
		
		
		public T next() {
			#line 526 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			return global::haxe.lang.Runtime.genericCast<T>(this.m.vals[this.i++]);
		}
		#line default
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.len = ((int) (@value) );
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 105:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.i = ((int) (@value) );
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					default:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.len = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 105:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.i = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					case 109:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						this.m = ((global::haxe.ds.IntMap<T>) (global::haxe.ds.IntMap<object>.__hx_cast<T>(((global::haxe.ds.IntMap) (@value) ))) );
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return @value;
					}
					
					
					default:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "next", 1224901875)) );
					}
					
					
					case 407283053:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hasNext", 407283053)) );
					}
					
					
					case 5393365:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.len;
					}
					
					
					case 105:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.i;
					}
					
					
					case 109:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.m;
					}
					
					
					default:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 5393365:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((double) (this.len) );
					}
					
					
					case 105:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return ((double) (this.i) );
					}
					
					
					default:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override object __hx_invokeField(string field, int hash, object[] dynargs) {
			unchecked {
				#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
				switch (hash) {
					case 1224901875:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.next();
					}
					
					
					case 407283053:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return this.hasNext();
					}
					
					
					default:
					{
						#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
			}
			#line default
		}
		
		
		public override void __hx_getFields(global::Array<string> baseArr) {
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("len");
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("i");
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			baseArr.push("m");
			#line 504 "/opt/haxe/std/cs/_std/haxe/ds/IntMap.hx"
			base.__hx_getFields(baseArr);
		}
		#line default
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds._IntMap {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds._IntMap.IntMapValueIterator<object>))]
	public interface IntMapValueIterator : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds__IntMap_IntMapValueIterator_cast<T_c>();
		
		bool hasNext();
		
	}
}

