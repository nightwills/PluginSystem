using System;

namespace MainInterface
{
	public interface IPlugin
	{
		string Name { get; } // имя плагина
		string DisplayName { get; } // имя плагина, которое отображается
		string Description { get; } // описание плагина
		string Author { get; } // имя автора
		int Version { get; } // версия
		IPluginHost Main { get; set; } // ссылка на главную форму

		void Visible(); // отображает форму
	}
	public interface IPluginHost
	{
		bool Register(IPlugin plug);
	}
}
