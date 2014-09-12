﻿using System;

namespace Projac
{
    /// <summary>
    ///     Represent a SQL projection descriptor.
    /// </summary>
    public class SqlProjectionDescriptor
    {
        private readonly string _identifier;
        private readonly SqlProjection _schemaProjection;
        private readonly SqlProjection _projection;

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlProjectionDescriptor"/> class.
        /// </summary>
        /// <param name="identifier">The projection identifier.</param>
        /// <param name="schemaProjection">The schema projection.</param>
        /// <param name="projection">The projection.</param>
        /// <exception cref="System.ArgumentNullException">Thrown when <paramref name="identifier"/>, <paramref name="schemaProjection"/> or <paramref name="projection"/> is <c>null</c>.</exception>
        public SqlProjectionDescriptor(string identifier, SqlProjection schemaProjection, SqlProjection projection)
        {
            if (identifier == null) throw new ArgumentNullException("identifier");
            if (schemaProjection == null) throw new ArgumentNullException("schemaProjection");
            if (projection == null) throw new ArgumentNullException("projection");
            _identifier = identifier;
            _schemaProjection = schemaProjection;
            _projection = projection;
        }

        /// <summary>
        /// Gets the projection identifier.
        /// </summary>
        /// <value>
        /// The projection identifier.
        /// </value>
        public string Identifier
        {
            get { return _identifier; }
        }

        /// <summary>
        /// Gets the schema projection.
        /// </summary>
        /// <value>
        /// The schema projection.
        /// </value>
        public SqlProjection SchemaProjection
        {
            get { return _schemaProjection; }
        }

        /// <summary>
        /// Gets the projection.
        /// </summary>
        /// <value>
        /// The projection.
        /// </value>
        public SqlProjection Projection
        {
            get { return _projection; }
        }
    }
}