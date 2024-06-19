using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Diagnostics;

namespace project_with_oleg
{
    public partial class UC_Trading : UserControl
    {

        public UC_Trading()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            string html = @"
                <!-- TradingView Widget BEGIN -->
                <div class='tradingview-widget-container'>
                  <div class='tradingview-widget-container__widget'></div>
                  <div class='tradingview-widget-copyright'>
                    <a href='https://www.tradingview.com/' rel='noopener nofollow' target='_blank'>
                      <span class='blue-text'>Track all markets on TradingView</span>
                    </a>
                  </div>
                  <script type='text/javascript' src='https://s3.tradingview.com/external-embedding/embed-widget-symbol-overview.js' async>
                  {
                  'symbols': [
                    [
                      'BINANCE:BTCUSDT|1D'
                    ],
                    [
                      'BINANCE:ETHUSDT|1D'
                    ],
                    [
                      'BINANCE:BNBUSDT|1D'
                    ]
                  ],
                  'chartOnly': false,
                  'width': '100%',
                  'height': '100%',
                  'locale': 'en',
                  'colorTheme': 'light',
                  'autosize': true,
                  'showVolume': false,
                  'showMA': false,
                  'hideDateRanges': false,
                  'hideMarketStatus': false,
                  'hideSymbolLogo': false,
                  'scalePosition': 'right',
                  'scaleMode': 'Normal',
                  'fontFamily': '-apple-system, BlinkMacSystemFont, Trebuchet MS, Roboto, Ubuntu, sans-serif',
                  'fontSize': '10',
                  'noTimeScale': false,
                  'valuesTracking': '1',
                  'changeMode': 'price-and-percent',
                  'chartType': 'area',
                  'maLineColor': '#2962FF',
                  'maLineWidth': 1,
                  'maLength': 9,
                  'lineWidth': 2,
                  'lineType': 0,
                  'dateRanges': [
                    '1d|1',
                    '1m|30',
                    '3m|60',
                    '12m|1D',
                    '60m|1W',
                    'all|1M'
                  ]
                  }
                  </script>
                </div>
                <!-- TradingView Widget END -->";

            //webBrowser1.DocumentText = html;
            webBrowser1.Navigate("www.google.com");
        }
    }


}
