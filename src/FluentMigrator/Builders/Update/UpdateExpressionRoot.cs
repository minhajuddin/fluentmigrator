﻿using FluentMigrator.Expressions;
using FluentMigrator.Infrastructure;

namespace FluentMigrator.Builders.Update
{
    public class UpdateExpressionRoot : IUpdateExpressionRoot
	{
		private readonly IMigrationContext _context;

		public UpdateExpressionRoot(IMigrationContext context)
		{
			_context = context;
		}

		//public void Schema(string schemaName)
		//{
		//    var expression = new AlterSchemaExpression { SchemaName = schemaName };
		//    _context.Expressions.Add(expression);
		//}

        public IUpdateSetOrInSchemaSyntax Table(string tableName)
		{
			var expression = new UpdateDataExpression { TableName = tableName};
			_context.Expressions.Add(expression);
			return new UpdateDataExpressionBuilder(expression, _context);
		}
	}
}
