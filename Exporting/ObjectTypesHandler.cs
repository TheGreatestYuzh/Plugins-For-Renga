using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Renga;

namespace RengaExtensions.Exporting
{
    public class ObjectTypesHandler
    {
        public static Dictionary<string, Guid> Map = new Dictionary<string, Guid>
        {
            { "Аксессуары воздуховода", ObjectTypes.DuctAccessory },
            { "Угловые размеры", ObjectTypes.AngularDimension },
            { "Аксессуары трубопровода", ObjectTypes.PipeAccessory },
            { "Сборки", ObjectTypes.AssemblyInstance},
            { "Оси" , ObjectTypes.Axis },
            { "Колонны", ObjectTypes.Column},
            { "Диаметральные размеры", ObjectTypes.DiametralDimension},
            { "Двери", ObjectTypes.Door },
            { "Воздуховоды", ObjectTypes.Duct},
            { "Детали воздуховода", ObjectTypes.DuctFitting},
            { "Электрические распределительные щиты", ObjectTypes.ElectricDistributionBoard},
            { "Элементы", ObjectTypes.Element},
            { "Фасады", ObjectTypes.Elevation},
            { "Оборудование", ObjectTypes.Equipment },
            { "Перекрытия", ObjectTypes.Floor},
            { "Уровни", ObjectTypes.Level},
            { "Штриховки модели", ObjectTypes.Hatch},
            { "Проёмы", ObjectTypes.Hole},
            { "Разрезы",ObjectTypes.Opening},
            { "Помещения", ObjectTypes.IfcObject},
            { "Санитарно-техническое оборудование", ObjectTypes.PlumbingFixture},
            { "Трубы", ObjectTypes.Pipe},
            { "Детали трубопровода", ObjectTypes.PipeFitting},
            { "Крыши", ObjectTypes.Roof},
            { "Осветительные приборы", ObjectTypes.LightFixture},
            { "Пластины", ObjectTypes.Plate},
            { "Радиальные размеры", ObjectTypes.RadialDimension},
            { "Ограждения", ObjectTypes.Railing},
            { "Лестницы", ObjectTypes.Stair},
            { "Тексты модели", ObjectTypes.TextObject},
            { "Пандусы", ObjectTypes.Ramp},
            { "Стены", ObjectTypes.Wall},
            { "Балки", ObjectTypes.Beam },
            { "Окна", ObjectTypes.Window },
            { "Электрические линии", ObjectTypes.LineElectricalCircuit },
            { "Разделы", ObjectTypes.Section},
            { "Линейные размеры", ObjectTypes.LinearDimension},
            { "Вентиляционное оборудование", ObjectTypes.MechanicalEquipment},
            { "Ленточные фундаменты", ObjectTypes.IsolatedFoundation},
            { "Линии модели", ObjectTypes.Line3D},
            { "Арматурные изделия", ObjectTypes.Rebar},
            { "Трассы", ObjectTypes.Route},
            { "Точки трассировки", ObjectTypes.RoutePoint},
            { "Столбчатые фундаменты", ObjectTypes.WallFoundation},
            { "Электроустановочные изделия", ObjectTypes.WiringAccessory},
        
            { "Стили балки", StyleTypeIds.BeamStyle},
            { "Стили колонны", StyleTypeIds.ColumnStyle},
            { "Стили двери", StyleTypeIds.DoorStyle},
            { "Стили аксессуара воздуховода", StyleTypeIds.DuctAccessoryStyle},
            { "Стили детали воздуховода", StyleTypeIds.DuctFittingStyle},
            { "Стили воздуховода", StyleTypeIds.DuctStyle},
            { "Стили электрической линии", StyleTypeIds.ElectricCircuitLineStyle},
            { "Стили электрического распределительного щита", StyleTypeIds.ElectricDistributionBoardStyle},
            { "Стили элемента", StyleTypeIds.ElementStyle},
            { "Стили оборудования", StyleTypeIds.EquipmentStyle},
            { "Стили осветительного прибора", StyleTypeIds.LightingFixtureStyle},
            { "Стили аксессуара трубопровода", StyleTypeIds.PipeAccessoryStyle},
            { "Стили детали трубопровода", StyleTypeIds.PipeFittingStyle},
            { "Стили трубы", StyleTypeIds.PipeStyle},
            { "Стили пластины", StyleTypeIds.PlateStyle},
            { "Стили санитарно-текнического оборудования", StyleTypeIds.PlumbingFixtureStyle},
            { "Стили системы", StyleTypeIds.SystemStyle},
            { "Стили окна", StyleTypeIds.WindowStyle},
            { "Стили арматурного изделия", StyleTypeIds.ReinforcementStyle},
            { "Стили сборки", StyleTypeIds.Assembly},
            { "Стили арматурой детали", StyleTypeIds.ReinforcementItem},
            { "Стили проводника", StyleTypeIds.WiringAccessoryStyle},
            { "Стили электроустановочного изделия", StyleTypeIds.ElectricalConductorStyle},
            { "Стили вентиляционного оборудования", StyleTypeIds.MechanicalEquipmentStyle},
            { "Материалы", StyleTypeIds.Material},
            { "Многослойные материалы", StyleTypeIds.LayeredMaterial},
            { "Арматурные детали", StyleTypeIds.ReinforcementUnit},
            { "Здания", StyleTypeIds.BuildingElementModel},
        };

        public Guid this[string russkoeImya] { get => Map[russkoeImya]; }
    }
}
