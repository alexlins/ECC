using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EccCross.ViewModel.Request;
using EccCross.ViewModel.Response;

namespace EccInfra.Repository
{
    public class CasalRepository
    {
        private EccEntities _entity;

        public CasalRepository()
        {
            _entity = new EccEntities();
        }

        public List<CasalResponseViewModel> GetAll()
        {
            var listaCasais = _entity.Casais.ToList();

            if (listaCasais.Count == 0)
                return new List<CasalResponseViewModel>();

            List<CasalResponseViewModel> resultado = new List<CasalResponseViewModel>();

            foreach (var item in listaCasais)
            {
                resultado.Add(MontaViewModel(item));
            }

            return resultado;
        }

        public CasalResponseViewModel GetById(int id)
        {
            try
            {
                var result = _entity.Casais.Where(x => x.CasalId == id).First();
                return MontaViewModel(result);
            }
            catch (Exception ex)
            {
                return new CasalResponseViewModel();
            }
        }

        public CasalResponseViewModel AddOrUpdate(CasalRequestViewModel item)
        {
            Casais cc;
            if (item.CasalId == 0)
                cc = new Casais();
            else
            {
                cc = _entity.Casais.Where(x => x.CasalId == item.CasalId).FirstOrDefault();
                if (cc.CasalId == 0)
                    return new CasalResponseViewModel();
            }

            if (item.DtEstadoCivil == DateTime.MinValue)
                item.DtEstadoCivil = new DateTime(1900, 1, 1);

            cc.NomeEle = item.NomeEle;
            cc.NomeEla = item.NomeEla;
            cc.ReligiaoEle = item.ReligiaoEle;
            cc.ReligiaoEla = item.ReligiaoEla;
            cc.DtNascimentoEle = item.DtNascimentoEle;
            cc.DtNascimentoEla = item.DtNascimentoEla;
            cc.EstadoCivil = item.EstadoCivil;
            cc.DtEstadoCivil = item.DtEstadoCivil;
            cc.Endereco = item.Endereco;
            cc.CEP = item.CEP;
            cc.Numero = item.Numero;
            cc.Complemento = item.Complemento;
            cc.Bairro = item.Bairro;
            cc.Cidade = item.Cidade;
            cc.UF = item.UF;
            cc.TelResidencial = item.TelResidencial;
            cc.CelularEle = item.CelularEle;
            cc.CelularEla = item.CelularEla;
            cc.EmailEle = item.EmailEle;
            cc.EmailEla = item.EmailEla;
            cc.ProfissaoEle = item.ProfissaoEle;
            cc.ProfissaoEla = item.ProfissaoEla;
            cc.LocalTrabalhoEle = item.LocalTrabalhoEle;
            cc.LocalTrabalhoEla = item.LocalTrabalhoEla;
            cc.CidadeTrabalhoEle = item.CidadeTrabalhoEle;
            cc.CidadeTrabalhoEla = item.CidadeTrabalhoEla;
            cc.PaiEle = item.PaiEle;
            cc.MaeEle = item.MaeEle;
            cc.EnderecoPaisEle = item.EnderecoPaisEle;
            cc.NumeroPaisEle = item.NumeroPaisEle;
            cc.BairroPaisEle = item.BairroPaisEle;
            cc.CidadePaisEle = item.CidadePaisEle;
            cc.UFPaisEle = item.UFPaisEle;
            cc.CEPPaisEle = item.CEPPaisEle;
            cc.TelResPaisEle = item.TelResPaisEle;
            cc.TelCelPaisEle = item.TelCelPaisEle;
            cc.PaiEla = item.PaiEla;
            cc.MaeEla = item.MaeEla;
            cc.EnderecoPaisEla = item.EnderecoPaisEla;
            cc.NumeroPaisEla = item.NumeroPaisEla;
            cc.BairroPaisEla = item.BairroPaisEla;
            cc.CidadePaisEla = item.CidadePaisEla;
            cc.UFPaisEla = item.UFPaisEla;
            cc.CEPPaisEla = item.CEPPaisEla;
            cc.TelResPaisEla = item.TelResPaisEla;
            cc.TelCelPaisEla = item.TelCelPaisEla;


            if (cc.CasalId == 0)
            {
                var ultimo = _entity.Casais.OrderByDescending(o => o.CasalId).ToList();
                if (ultimo.Any())
                    cc.CasalId = ultimo[0].CasalId + 1;
                else
                    cc.CasalId = 1;
                _entity.AddObject("Casais", cc);
            }

            _entity.SaveChanges();

            return MontaViewModel(cc);
        }

        private CasalResponseViewModel MontaViewModel(Casais item)
        {
            return new CasalResponseViewModel
            {
                CasalId = item.CasalId,
                NomeEle = item.NomeEle,
                NomeEla = item.NomeEla,
                ReligiaoEle = item.ReligiaoEle,
                ReligiaoEla = item.ReligiaoEla,
                DtNascimentoEle = item.DtNascimentoEle.Value,
                DtNascimentoEla = item.DtNascimentoEla.Value,
                EstadoCivil = item.EstadoCivil,
                DtEstadoCivil = item.DtEstadoCivil.Value,
                Endereco = item.Endereco,
                CEP = item.CEP,
                Numero = item.Numero,
                Complemento = item.Complemento,
                Bairro = item.Bairro,
                Cidade = item.Cidade,
                UF = item.UF,
                TelResidencial = item.TelResidencial,
                CelularEle = item.CelularEle,
                CelularEla = item.CelularEla,
                EmailEle = item.EmailEle,
                EmailEla = item.EmailEla,
                ProfissaoEle = item.ProfissaoEle,
                ProfissaoEla = item.ProfissaoEla,
                LocalTrabalhoEle = item.LocalTrabalhoEle,
                LocalTrabalhoEla = item.LocalTrabalhoEla,
                CidadeTrabalhoEle = item.CidadeTrabalhoEle,
                CidadeTrabalhoEla = item.CidadeTrabalhoEla,
                PaiEle = item.PaiEle,
                MaeEle = item.MaeEle,
                EnderecoPaisEle = item.EnderecoPaisEle,
                NumeroPaisEle = item.NumeroPaisEle,
                BairroPaisEle = item.BairroPaisEle,
                CidadePaisEle = item.CidadePaisEle,
                UFPaisEle = item.UFPaisEle,
                CEPPaisEle = item.CEPPaisEle,
                TelResPaisEle = item.TelResPaisEle,
                TelCelPaisEle = item.TelCelPaisEle,
                PaiEla = item.PaiEla,
                MaeEla = item.MaeEla,
                EnderecoPaisEla = item.EnderecoPaisEla,
                NumeroPaisEla = item.NumeroPaisEla,
                BairroPaisEla = item.BairroPaisEla,
                CidadePaisEla = item.CidadePaisEla,
                UFPaisEla = item.UFPaisEla,
                CEPPaisEla = item.CEPPaisEla,
                TelResPaisEla = item.TelResPaisEla,
                TelCelPaisEla = item.TelCelPaisEla
            };
        }

    }
}
