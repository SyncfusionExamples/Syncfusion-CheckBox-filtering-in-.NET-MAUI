using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CheckBoxFiltering
{
    public class ProductInfoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region Properties

        private bool brandFilterChecked1;
        public bool BrandFilterChecked1
        {
            get { return brandFilterChecked1; }
            set
            {
                if (brandFilterChecked1 != value)
                {
                    brandFilterChecked1 = value;
                    OnPropertyChanged(nameof(BrandFilterChecked1));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool brandFilterChecked2 = true;
        public bool BrandFilterChecked2
        {
            get { return brandFilterChecked2; }
            set
            {
                if (brandFilterChecked2 != value)
                {
                    brandFilterChecked2 = value;
                    OnPropertyChanged(nameof(BrandFilterChecked2));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool brandFilterChecked3 = true;
        public bool BrandFilterChecked3
        {
            get { return brandFilterChecked3; }
            set
            {
                if (brandFilterChecked3 != value)
                {
                    brandFilterChecked3 = value;
                    OnPropertyChanged(nameof(BrandFilterChecked3));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool brandFilterChecked4;
        public bool BrandFilterChecked4
        {
            get { return brandFilterChecked4; }
            set
            {
                if (brandFilterChecked4 != value)
                {
                    brandFilterChecked4 = value;
                    OnPropertyChanged(nameof(BrandFilterChecked4));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool sizeFilterChecked2 = true;
        public bool SizeFilterChecked2
        {
            get { return sizeFilterChecked2; }
            set
            {
                if (sizeFilterChecked2 != value)
                {
                    sizeFilterChecked2 = value;
                    OnPropertyChanged(nameof(SizeFilterChecked2));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool sizeFilterChecked3 = true;
        public bool SizeFilterChecked3
        {
            get { return sizeFilterChecked3; }
            set
            {
                if (sizeFilterChecked3 != value)
                {
                    sizeFilterChecked3 = value;
                    OnPropertyChanged(nameof(SizeFilterChecked3));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool sizeFilterChecked4;
        public bool SizeFilterChecked4
        {
            get { return sizeFilterChecked4; }
            set
            {
                if (sizeFilterChecked4 != value)
                {
                    sizeFilterChecked4 = value;
                    OnPropertyChanged(nameof(SizeFilterChecked4));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool sizeFilterChecked5;
        public bool SizeFilterChecked5
        {
            get { return sizeFilterChecked5; }
            set
            {
                if (sizeFilterChecked5 != value)
                {
                    sizeFilterChecked5 = value;
                    OnPropertyChanged(nameof(SizeFilterChecked5));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool colorFilterChecked1;
        public bool ColorFilterChecked1
        {
            get { return colorFilterChecked1; }
            set
            {
                if (colorFilterChecked1 != value)
                {
                    colorFilterChecked1 = value;
                    OnPropertyChanged(nameof(colorFilterChecked1));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool colorFilterChecked2 = true;
        public bool ColorFilterChecked2
        {
            get { return colorFilterChecked2; }
            set
            {
                if (colorFilterChecked2 != value)
                {
                    colorFilterChecked2 = value;
                    OnPropertyChanged(nameof(colorFilterChecked2));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool colorFilterChecked3 = true;
        public bool ColorFilterChecked3
        {
            get { return colorFilterChecked3; }
            set
            {
                if (colorFilterChecked3 != value)
                {
                    colorFilterChecked3 = value;
                    OnPropertyChanged(nameof(colorFilterChecked3));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool colorFilterChecked4;
        public bool ColorFilterChecked4
        {
            get { return colorFilterChecked4; }
            set
            {
                if (colorFilterChecked4 != value)
                {
                    colorFilterChecked4 = value;
                    OnPropertyChanged(nameof(colorFilterChecked4));
                    UpdateFilteredProducts();
                }
            }
        }

        private bool colorFilterChecked5;
        public bool ColorFilterChecked5
        {
            get { return colorFilterChecked5; }
            set
            {
                if (colorFilterChecked5 != value)
                {
                    colorFilterChecked5 = value;
                    OnPropertyChanged(nameof(colorFilterChecked5));
                    UpdateFilteredProducts();
                }
            }
        }

        public ObservableCollection<ProductInfo> Products1 { get; set; }

        public ObservableCollection<ProductInfo> Products2 { get; set; }
        public ObservableCollection<ProductInfo> Products3 { get; set; }
        public ObservableCollection<ProductInfo> Products4 { get; set; }

        private ObservableCollection<ProductInfo>? filtered;
        public ObservableCollection<ProductInfo>? Filtered
        {
            get { return filtered; }
            set
            {
                if (filtered != value)
                {
                    filtered = value;
                    OnPropertyChanged(nameof(Filtered));
                }
            }
        }

        #endregion

        #region Constructor

        public ProductInfoViewModel()
        {
            Products1 = new ObservableCollection<ProductInfo>();
            Products2 = new ObservableCollection<ProductInfo>();
            Products3 = new ObservableCollection<ProductInfo>();
            Products4 = new ObservableCollection<ProductInfo>();

        string description1 = "Lightweight Sneakers for Men";
        string description2 = "Stylish Smart Sneakers for Men";

            Products1.Add(new ProductInfo("Campus", "brownshoe_01.png", "6   7   8", Colors.Brown, description1));
            Products1.Add(new ProductInfo("Campus", "greenshoe_02.png", "6   7   8   9   10", Colors.Green, description2));
            Products1.Add(new ProductInfo("Campus", "redshoe_03.png", "7   8   9   10 ", Colors.Red, description2));
            Products1.Add(new ProductInfo("Campus", "sandalshoe_04.png", "9   10", Colors.Tan, description2));
            Products1.Add(new ProductInfo("Campus", "violetshoe_05.png", "6   7", Colors.Violet, description1));
            Products1.Add(new ProductInfo("Campus", "brownshoe_02.png", "7   8   9", Colors.Brown, description2));
            Products1.Add(new ProductInfo("Campus", "greenshoe_03.png", "6   7   8   9", Colors.Green, description2));
            Products1.Add(new ProductInfo("Campus", "redshoe_04.png", "7   8   9   10", Colors.Red, description2));
            Products1.Add(new ProductInfo("Campus", "sandalshoe_05.png", "6   7   8   9   10", Colors.Tan, description1));
            Products1.Add(new ProductInfo("Campus", "violetshoe_01.png", "6   9   10", Colors.Violet, description1));

            Products2.Add(new ProductInfo("Skechers", "brownshoe_03.png", "6   7   8   9   10", Colors.Brown, description2));
            Products2.Add(new ProductInfo("Skechers", "greenshoe_04.png", "8   9   10", Colors.Green, description2));
            Products2.Add(new ProductInfo("Skechers", "redshoe_05.png", "6   7   9   10", Colors.Red, description1));
            Products2.Add(new ProductInfo("Skechers", "sandalshoe_01.png", "6   7   8   9   10", Colors.Tan, description1));
            Products2.Add(new ProductInfo("Skechers", "violetshoe_02.png", "6   7   10", Colors.Violet, description2));
            Products2.Add(new ProductInfo("Skechers", "brownshoe_04.png", "6   7   8   9   10", Colors.Brown, description2));
            Products2.Add(new ProductInfo("Skechers", "greenshoe_05.png", "6   7   8", Colors.Green, description1));
            Products2.Add(new ProductInfo("Skechers", "redshoe_01.png", "6   7   8   9   10", Colors.Red, description1));
            Products2.Add(new ProductInfo("Skechers", "sandalshoe_02.png", "8   9   10", Colors.Tan, description2));
            Products2.Add(new ProductInfo("Skechers", "violetshoe_03.png", "6   7   8   9   10", Colors.Violet, description2));

            Products3.Add(new ProductInfo("Red Tape", "brownshoe_05.png", "6   7   8   9   10", Colors.Brown, description1));
            Products3.Add(new ProductInfo("Red Tape", "greenshoe_01.png", "8   9   10", Colors.Green, description1));
            Products3.Add(new ProductInfo("Red Tape", "redshoe_02.png", "6   7   8   9   10", Colors.Red, description2));
            Products3.Add(new ProductInfo("Red Tape", "sandalshoe_03.png", "6   8   9   10", Colors.Tan, description2));
            Products3.Add(new ProductInfo("Red Tape", "violetshoe_04.png", "6   7   8   9   10", Colors.Violet, description2));
            Products3.Add(new ProductInfo("Red Tape", "brownshoe_01.png", "6   9   10", Colors.Brown, description1));
            Products3.Add(new ProductInfo("Red Tape", "greenshoe_02.png", "6   7   8   9   10", Colors.Green, description2));
            Products3.Add(new ProductInfo("Red Tape", "redshoe_03.png", "6   7   8", Colors.Red, description2));
            Products3.Add(new ProductInfo("Red Tape", "sandalshoe_04.png", "6   7   8   9   10", Colors.Tan, description2));
            Products3.Add(new ProductInfo("Red Tape", "violetshoe_05.png", "6   7   8   10", Colors.Violet, description1));

            Products4.Add(new ProductInfo("Roadster", "brownshoe_02.png", "6   7   8", Colors.Brown, description2));
            Products4.Add(new ProductInfo("Roadster", "greenshoe_03.png", "6   7   8   9   10", Colors.Green, description2));
            Products4.Add(new ProductInfo("Roadster", "redshoe_04.png", "6   9   10", Colors.Red, description2));
            Products4.Add(new ProductInfo("Roadster", "sandalshoe_05.png", "6   7   8   9   10", Colors.Tan, description1));
            Products4.Add(new ProductInfo("Roadster", "violetshoe_01.png", "6   9   10", Colors.Violet, description1));
            Products4.Add(new ProductInfo("Roadster", "brownshoe_03.png", "6   7   8   9   10", Colors.Brown, description2));
            Products4.Add(new ProductInfo("Roadster", "greenshoe_04.png", "8   9   10", Colors.Green, description2));
            Products4.Add(new ProductInfo("Roadster", "redshoe_05.png", "6   7   8   9   10", Colors.Red, description1));
            Products4.Add(new ProductInfo("Roadster", "sandalshoe_01.png", "6   7   10", Colors.Tan, description1));
            Products4.Add(new ProductInfo("Roadster", "violetshoe_02.png", "6   7   9   10", Colors.Violet, description2));

            UpdateFilteredProducts();
        }

        #endregion

        #region Methods

        private void UpdateFilteredProducts()
        {
            Filtered = GetFilteredProducts();
            OnPropertyChanged(nameof(Filtered));
        }

        private ObservableCollection<ProductInfo> GetFilteredProducts()
        {
            var filteredList = new ObservableCollection<ProductInfo>();

            if (brandFilterChecked1)
            {
                foreach (var product in Products1)
                {
                    if (IsColorChecked(product) || IsColorUnfiltered())
                        filteredList.Add(product);
                }
            }
            if (brandFilterChecked2)
            {
                foreach (var product in Products2)
                {
                    if (IsColorChecked(product) || IsColorUnfiltered())
                        filteredList.Add(product);
                }
            }
            if (brandFilterChecked3)
            {
                foreach (var product in Products3)
                {
                    if (IsColorChecked(product) || IsColorUnfiltered())
                        filteredList.Add(product);
                }
            }
            if (brandFilterChecked4)
            {
                foreach (var product in Products4)
                {
                    if (IsColorChecked(product) || IsColorUnfiltered())
                        filteredList.Add(product);
                }
            }
            if (!brandFilterChecked1 && !brandFilterChecked2 && !brandFilterChecked3 && !brandFilterChecked4)
            {
                filteredList = GetProducts();
            }

            List<ProductInfo> products = new List<ProductInfo>();
            products = filteredList.OrderBy(x => Random.Shared.Next()).ToList<ProductInfo>();
            filteredList = this.GetCollection(products);

            return filteredList;
        }

        private ObservableCollection<ProductInfo> GetCollection(List<ProductInfo> list)
        {
            var filteredList = new ObservableCollection<ProductInfo>();
            foreach (var product in list)
            {
                filteredList.Add(product);
            }
            return filteredList;
        }

        private ObservableCollection<ProductInfo> GetProducts()
        {
            var filteredList = new ObservableCollection<ProductInfo>();
            foreach (var product in Products1)
            {
                if (IsColorChecked(product) || IsColorUnfiltered())
                    filteredList.Add(product);
            }
            foreach (var product in Products2)
            {
                if (IsColorChecked(product) || IsColorUnfiltered())
                    filteredList.Add(product);
            }
            foreach (var product in Products3)
            {
                if (IsColorChecked(product) || IsColorUnfiltered())
                    filteredList.Add(product);
            }
            foreach (var product in Products4)
            {
                if (IsColorChecked(product) || IsColorUnfiltered())
                    filteredList.Add(product);
            }
            return filteredList;
        }

        private bool IsColorChecked(ProductInfo product)
        {
            return ((colorFilterChecked1 && product.Color == Colors.Brown) || (colorFilterChecked2 && product.Color == Colors.Green) || (colorFilterChecked3 && product.Color == Colors.Red) || (colorFilterChecked4 && product.Color == Colors.Tan) || (colorFilterChecked5 && product.Color == Colors.Violet));
        }

        private bool IsColorUnfiltered()
        {
            return (!colorFilterChecked1 && !colorFilterChecked2 && !colorFilterChecked3 && !colorFilterChecked4 && !colorFilterChecked5);
        }

        #endregion
    }
}
