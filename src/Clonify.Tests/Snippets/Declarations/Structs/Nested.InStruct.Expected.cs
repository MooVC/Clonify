namespace Clonify.Snippets.Declarations.Structs;

internal static partial class Nested
{
    public static partial class InStruct
    {
        public static class Expected
        {
            public static readonly Generated ConstructorForEncapsulatedValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public Inner(int value)
                            {
                                _value = value;
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasConstructorForEncapsulatedValue,
                "Clonify.Testing.Structs.Outter.Inner.ctor");

            public static readonly Generated ConversionFromValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static implicit operator int(Inner subject)
                            {
                                if (ReferenceEquals(subject, null))
                                {
                                    throw new ArgumentNullException("subject");
                                }

                                return subject._value;
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasConversionFrom,
                "Clonify.Testing.Structs.Outter.Inner.ConvertFrom");

            public static readonly Generated ConversionToValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static implicit operator Inner(int value)
                            {
                                return new Inner(value);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasConversionTo,
                "Clonify.Testing.Structs.Outter.Inner.ConvertTo");

            public static readonly Generated EquatableForSelf = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner : IEquatable<Inner>
                        {
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasEquatableForSelf,
                "Clonify.Testing.Structs.Outter.Inner.IEquatable.Self");

            public static readonly Generated EquatableForValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner : IEquatable<int>
                        {
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasEquatableForValue,
                "Clonify.Testing.Structs.Outter.Inner.IEquatable.Value");

            public static readonly Generated EqualityOperatorForSelf = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static bool operator ==(Inner left, Inner right)
                            {
                                if (ReferenceEquals(left, right))
                                {
                                    return true;
                                }

                                if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                                {
                                    return false;
                                }

                                return left.Equals(right);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasEqualityOperatorForSelf,
                "Clonify.Testing.Structs.Outter.Inner.Equality.Self");

            public static readonly Generated EqualityOperatorForValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static bool operator ==(Inner left, int right)
                            {
                                if (ReferenceEquals(left, right))
                                {
                                    return true;
                                }

                                if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                                {
                                    return false;
                                }

                                return left.Equals(right);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasEqualityOperatorForValue,
                "Clonify.Testing.Structs.Outter.Inner.Equality.Value");

            public static new readonly Generated Equals = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public override bool Equals(object other)
                            {
                                if (other is Inner)
                                {
                                    return Equals((Inner)other);
                                }

                                return false;
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasEqualsOverride,
                "Clonify.Testing.Structs.Outter.Inner.Equals");

            public static readonly Generated FieldForEncapsulatedValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            private readonly int _value;
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasFieldForEncapsulatedValue,
                "Clonify.Testing.Structs.Outter.Inner._value");

            public static new readonly Generated GetHashCode = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public override int GetHashCode()
                            {
                                return global::Clonify.Internal.HashCode.Combine(_value);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasGetHashCodeOverride,
                "Clonify.Testing.Structs.Outter.Inner.GetHashCode");

            public static readonly Generated InequalityOperatorForSelf = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static bool operator !=(Inner left, Inner right)
                            {
                                return !(left == right);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasInequalityOperatorForSelf,
                "Clonify.Testing.Structs.Outter.Inner.Inequality.Self");

            public static readonly Generated InequalityOperatorForValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public static bool operator !=(Inner left, int right)
                            {
                                return !(left == right);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasInequalityOperatorForValue,
                "Clonify.Testing.Structs.Outter.Inner.Inequality.Value");

            public static new readonly Generated ToString = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public override string ToString()
                            {
                                return string.Format("Inner {{ {0} }}", _value);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.HasToStringOverride,
                "Clonify.Testing.Structs.Outter.Inner.ToString");

            public static readonly Generated EquatableToSelf = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public bool Equals(Inner other)
                            {
                                if (ReferenceEquals(this, other))
                                {
                                    return true;
                                }

                                if (ReferenceEquals(other, null))
                                {
                                    return false;
                                }

                                return Equals(other._value);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.IsEquatableToSelf,
                "Clonify.Testing.Structs.Outter.Inner.IEquatable.Self.Equals");

            public static readonly Generated EquatableToValue = new(
                """
                namespace Clonify.Testing.Structs
                {
                    using System;
                    using System.Collections.Generic;

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable disable
                    #endif

                    readonly ref partial struct Outter<T>
                    {
                        readonly partial struct Inner
                        {
                            public bool Equals(int other)
                            {
                                if (ReferenceEquals(this, other))
                                {
                                    return true;
                                }

                                if (ReferenceEquals(other, null))
                                {
                                    return false;
                                }

                                return global::System.Collections.Generic.EqualityComparer<int>.Default.Equals(_value, other);
                            }
                        }
                    }

                    #if NET5_0_OR_GREATER || NETSTANDARD2_1_OR_GREATER
                    #nullable restore
                    #endif
                }
                """,
                Extensions.IsEquatableToValue,
                "Clonify.Testing.Structs.Outter.Inner.IEquatable.Value.Equals");
        }
    }
}