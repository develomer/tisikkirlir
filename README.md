Tisikkirlir

![cat](https://dl.dropbox.com/s/x2otko6ropilnb0/Birikindi-sizin-i%C3%A7in-sivisiyim-kilisi.jpg)


## Kullanýmý

dll referanslara eklendikten sonra;
			
			using tisikkirlir;

			static void Main(string[] args)
			{
				string str = Console.ReadLine();

				tisikkirlir tsk = new tisikkirlir();

				Console.Write(tsk.funcTsk(str));
				Console.ReadKey();
			}

## Contributing

1. Fork it ( https://github.com/develomer/tisikkirlir/fork )
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create a new Pull Request