using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Infrastructure.Data
{
    /// <summary>
    /// 数据实体和Dto转换辅助类
    /// </summary>
    public class Mapper
    {
        private static Dictionary<TypePair, IMapper> _mappers;
        static Mapper()
        {
            _mappers = new Dictionary<TypePair, IMapper>();
        }
        private static IMapper getMapper<TSource, TDestination>(Func<IMapperConfigurationExpression, IMappingExpression<TSource, TDestination>> mappingExpression)
        {
            var typePair = new TypePair(typeof(TSource), typeof(TDestination));
            if (_mappers.ContainsKey(typePair))
                return _mappers[typePair];

            var config = new MapperConfiguration(cfg => mappingExpression(cfg));
            var mapper = config.CreateMapper();
            _mappers.Add(typePair, mapper);
            return mapper;
        }
        /// <summary>
        /// 转换方法
        /// </summary>
        /// <typeparam name="TSource">源数据类型</typeparam>
        /// <typeparam name="TDestination">目标数据类型</typeparam>
        /// <param name="mappingExpression">可返回映射表达式的函数</param>
        /// <param name="source">源对象</param>
        /// <param name="dest">目标对象</param>
        public static void Resolve<TSource, TDestination>(Func<IMapperConfigurationExpression, IMappingExpression<TSource, TDestination>> mappingExpression, TSource source, TDestination dest)
        {
            var mapper = getMapper(mappingExpression);
            mapper.Map(source, dest);
        }
    }
}
