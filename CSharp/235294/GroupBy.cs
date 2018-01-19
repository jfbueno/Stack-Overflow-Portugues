var processo = Processos.GroupBy(p => new 
                                { 
                                    p.SituacaoProcessoId, 
                                    Descr = p.SituacaoProcesso.Descricao 
                                })
                                .Select(p => new
                                {
                                    Descricao = p.Key.Descr,
                                    Total = p.Count()
                                });